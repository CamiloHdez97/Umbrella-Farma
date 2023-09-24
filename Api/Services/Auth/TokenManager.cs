using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Dtos.Auth;
using Domain.Entities;
using Domain.Interfaces.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Api.Helpers;

public sealed class TokenManager : ITokenManager{
    private readonly IPasswordHasher<User> _PasswordHasher;
    private readonly IConfiguration _Conf;
    private readonly int _AccessTokenDuration;
    private readonly int _RefreshTokenTokenDuration;

    public TokenManager(IPasswordHasher<User> passwordHasher, IConfiguration conf ){
        _Conf = conf;
        _PasswordHasher = passwordHasher;
        //--Token duration
        _ = int.TryParse(conf["JWTSettings:AccessTokenTimeInMinutes"], out _AccessTokenDuration);
        _ = int.TryParse(conf["JWTSettings:RefreshTokenTimeInHours"], out _RefreshTokenTokenDuration);

    }
    //Validar contraseña
    public  bool ValidatePassword(User user, string password){
        return _PasswordHasher.VerifyHashedPassword(
                    user,
                    user.Password,
                    password
                ) == PasswordVerificationResult.Success;
    }
    public User CreateUser(UserSignup model){
        //-Crear Usuario
        User user = new(){
            Email = model.Email!,
            UserName = model.Username!
        };

        //-Encriptar Password
        user.Password = _PasswordHasher.HashPassword(user,model.Password!);

        //-Retornar usuario
        return user;
    }

    private SymmetricSecurityKey GetSecurityKey(){
        //-Obterner Key
        var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    _Conf["JWTSettings:Key"] ??
                    throw new Exception("Error: key not found"
                )));
        return key;
    }



    public  string CreateAccessToken(User user){
        //-Define Claims
        var claims = new List<Claim>(){
            new(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            new(ClaimTypes.Name,user.UserName),
            new(ClaimTypes.Email,user.Email!),
            new(ClaimTypes.Role,user.Role!.Description)
        };

        var date = new DateTime();
        date = DateTime.Now.AddMinutes(_AccessTokenDuration);
        //-Return Token
        return CreateToken(claims,date);
    }

    public  string CreateRefreshToken(){
        //-Define Claims
        var claims = new List<Claim>(){
                new(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())};

        var date = new DateTime();
        date = DateTime.Now.AddHours(_RefreshTokenTokenDuration);
        //-Return Token
        return CreateToken(claims,date);
    }

    private string CreateToken(IEnumerable<Claim> claims, DateTime expireTime){
        //-Firmar Credenciales
        var credentials = new SigningCredentials(GetSecurityKey(), SecurityAlgorithms.HmacSha512Signature);

        //-Agregar descripcion
        var tokenDescription = new SecurityTokenDescriptor{
            Issuer = _Conf["JWTSettings:Issuer"],
            Audience = _Conf["JWTSettings:Audience"],
            Subject = new ClaimsIdentity(claims),
            NotBefore = DateTime.Now,
            Expires = expireTime,
            SigningCredentials = credentials
        };

        //-Crear Token
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescription);

        //-Retornar token como string
        return tokenHandler.WriteToken(token);
    }


}

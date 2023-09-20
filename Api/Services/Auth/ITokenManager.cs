using System.Security.Claims;
using Api.Dtos.Auth;
using Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Interfaces.Auth;
public interface ITokenManager{
    string CreateAccessToken(User user);
    string CreateRefreshToken();
    User CreateUser(UserSignup model);
    bool ValidatePassword(User user, string password);
}

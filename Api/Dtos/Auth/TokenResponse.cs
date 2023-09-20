namespace Api.Dtos.Auth;
public class TokenResponse{
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public bool IsAuthenticated { get; set; }
    public  string Message { get; set; } = null!;
    public string AccessToken { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
}

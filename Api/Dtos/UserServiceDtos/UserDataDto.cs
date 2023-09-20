namespace Api.Dtos;
public class UserDataDto{
    public string Username { get; set; } = null!;
    public bool IsAuthenticated { get; set; }
    public  string Message { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Token { get; set; } = null!;
}

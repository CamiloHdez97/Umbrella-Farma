namespace Api.Dtos;
public class UserXRolDto: UserDto{
    public HashSet<RolDto>? Rols { get; set; } = new HashSet<RolDto>();
    
}
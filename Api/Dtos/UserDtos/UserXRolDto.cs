namespace Api.Dtos;
public class UserXRolDto: UserDto{
    public HashSet<RoleDto>? Rols { get; set; } = new HashSet<RoleDto>();
    
}
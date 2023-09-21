namespace Api.Dtos;
public class RoleXUserDtos:RoleDtoWithId{    
    public HashSet<UserDto>? Users { get; set; } = new HashSet<UserDto>();
}

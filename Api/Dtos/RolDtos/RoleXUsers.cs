namespace Api.Dtos;
public class RoleXUserDtos:RoleWithIdDto{    
    public HashSet<UserDto> Users { get; set; } = new HashSet<UserDto>();
}

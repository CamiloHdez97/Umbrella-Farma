namespace Api.Dtos;
public class RolXUserDtos:RolDtoWithId{    
    public HashSet<UserDto>? Users { get; set; } = new HashSet<UserDto>();
}

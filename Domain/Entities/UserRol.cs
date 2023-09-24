namespace Domain.Entities;

    public class UserRol
    {
        public int UserId { get; set; }
        public User User{ get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
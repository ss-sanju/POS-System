namespace POSSystem.Models.User_Management
{
    public class Roles
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

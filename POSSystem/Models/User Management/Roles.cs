using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.User_Management
{
    public class Roles
    {
        [Key]
        [Required(ErrorMessage = "Role Id is required.")]
        [StringLength(20)]
        [Display(Name = "Role Id")]
        public Guid RoleId { get; set; }
        [Required(ErrorMessage = "Role Name is required.")]
        [StringLength(30)]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(250)]
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}

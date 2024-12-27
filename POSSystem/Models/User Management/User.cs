using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace POSSystem.Models.User_Management;

public class User
{
    [Key]
    [Required(ErrorMessage ="User Id is required.")]
    [StringLength(20)]
    public int UserId { get; set; }
    [Required(ErrorMessage = "Full Name is required.")]
    [StringLength(20)]
    public string FullName { get; set; }
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(20)]
    [Display(Name = "User Name")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Password is required.")]
    [StringLength(32)]
    [Display(Name = "Password")]
    public string PasswordHash { get; set; }
    [Required(ErrorMessage = "Role Id is required.")]
    [StringLength(20)]
    public Guid RoleId { get; set; }
    [Required(ErrorMessage = "Email is required.")]
    [StringLength(20)]
    public string Email { get; set; }
    [Required(ErrorMessage = "Phone Number is required.")]
    [StringLength(20)]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }
    [Required(ErrorMessage = "Phone Number is required.")]
    [StringLength(20)]
    [Display(Name = "Status")]
    public bool IsActive { get; set; }
    [ForeignKey("RoleId")]
    public Roles Roles { get; set; }
}

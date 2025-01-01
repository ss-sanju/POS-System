using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Product_Management;

public class Vendor
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string ContactName { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Address { get; set; }
}

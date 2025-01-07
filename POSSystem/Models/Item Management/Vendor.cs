using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Item_Management;

public class Vendor
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required,StringLength(100)]
    public string Name { get; set; }
    [Required,StringLength(100)]
    public string ContactName { get; set; }
    [Required, StringLength(20)]
    [Phone]
    public string PhoneNumber { get; set; }
    [Required, StringLength(100)]
    [EmailAddress]
    public string Email { get; set; }
    [Required, StringLength(100)]
    public string Address { get; set; }
}

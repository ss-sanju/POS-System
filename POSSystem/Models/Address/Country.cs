using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Address;

public class Country
{
    [Key]
    public Guid Id { get; set; }
    [StringLength(100)]
    [Required]
    public string Name { get; set; }
    
    [StringLength(10)]
    [Required]
    public string CountryCode { get; set; }
}

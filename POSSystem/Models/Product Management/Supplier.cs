using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Product_Management
{
    public class Supplier
    {
        [Key]
        [Required]
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}

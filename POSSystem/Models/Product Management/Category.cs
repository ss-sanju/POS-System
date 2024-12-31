using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Product_Management
{
    public class Category
    {
        [Key]
        [Required]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Item> Products { get; set; }
    }
}

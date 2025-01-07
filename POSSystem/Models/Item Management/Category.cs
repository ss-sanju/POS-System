using POSSystem.Models.Item_Management;
using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models.Item_Management
{
    
    public class Category
    {
        [Key]
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}

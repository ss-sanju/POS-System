using Microsoft.AspNetCore.Http.HttpResults;
using POSSystem.Models.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSSystem.Models.Product_Management
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage ="Product Id is required.")]
        public Guid ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(100)]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(250)]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Category Id is required.")]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Cost is required.")]
        public decimal? Cost { get; set; }
        [Required(ErrorMessage = "Stock Quantity is required.")]
        [Display(Name = "Stock Qty")]
        public int StockQuantity { get; set; }
        [Required(ErrorMessage = "Barcode is required.")]
        public string Barcode { get; set; }
        // Date and time the item was created
        [Required]
        public DateTime? CreatedAt { get; set; }

        // Date and time the item was last updated
        public DateTime? UpdatedAt { get; set; }
        // Availability status
        [Required]
        public bool IsAvailable { get; set; }
        [Display(Name = "Status")]
        public Status Status { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public Product()
        {
            ProductId = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

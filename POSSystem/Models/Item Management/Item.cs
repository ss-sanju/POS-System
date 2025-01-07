using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using POSSystem.Models.Enum;
using POSSystem.Models.Enum.Item;
using POSSystem.Models.Product_Management;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSSystem.Models.Item_Management;

/// <summary>
/// Represents a item
/// </summary>
public class Item
{
    /// <summary>
    /// Gets or sets the item identifier
    /// </summary>
    [Key]
    [Required(ErrorMessage ="Item Id is required.")]
    public Guid Id { get; set; }
    /// <summary>
    /// Gets or sets the item name
    /// </summary>
    [Required(ErrorMessage = "Item Name is required.")]
    [StringLength(100)]
    [Display(Name ="Name")]
    public string ItemName { get; set; }
    /// <summary>
    /// Gets or sets the description
    /// </summary>
    [Required(ErrorMessage = "Description is required.")]
    [StringLength(250)]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Category Id is required.")]
    public Guid CategoryId { get; set; }
    /// <summary>
    /// Gets or sets the Base Unit of Measure
    /// </summary>
    [Required]
    [StringLength(10)]
    [Display(Name ="Base Unit of Measure")]
    public UnitofMeasure UnitofMeasure {  get; set; }
    /// <summary>
    /// Gets or sets the stock quantity
    /// </summary>
    [Required]
    [Display(Name = "Stock Qty")]
    public int StockQty { get; set; }
    /// <summary>
    /// Gets or sets the price
    /// </summary>
    [Required(ErrorMessage = "Unit Price is required.")]
    [Display(Name ="Unit Price")]
    [Precision(18, 2)] // Precision: 18 digits, Scale: 2 digits after the decimal point
    public decimal UnitPrice { get; set; }
    /// <summary>
    /// Gets or sets the product cost
    /// </summary>
    [Required(ErrorMessage = "Cost is required.")]
    [Display(Name = "Unit Cost")]
    [Precision(18, 2)] // Precision: 18 digits, Scale: 2 digits after the decimal point
    public decimal UnitCost { get; set; }
  
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
    /// <summary>
    /// Gets or sets a value indicating whether the product is marked as tax exempt
    /// </summary>
    public bool IsTaxExempt { get; set; }

    /// <summary>
    /// Gets or sets the tax category identifier
    /// </summary>
    public int TaxCategoryId { get; set; }
    //[Required]
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    public Item()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        //UpdatedAt = DateTime.UtcNow;
    }
}

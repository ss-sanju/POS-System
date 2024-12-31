using POSSystem.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace POSSystem.Models.Customer_Management
{
    public class Customer
    {
        [Required]
        [StringLength(20)]
        [Display(Name="Customer Code")]
        public Guid Code { get; set; }
      
        /// <summary>
        /// Gets or sets the First name
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "Customer First Name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the Last name
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "Customer Last Name")]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        [StringLength(20)]
        [Phone]
        [Display(Name ="Phone No.")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Gets or sets the description
        /// </summary>

        [StringLength(250)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the picture identifier
        /// </summary>
        public Guid PictureId { get; set; }
        /// <summary>
        /// Gets or sets the address
        /// </summary>
        [StringLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the country id
        /// </summary>
        [StringLength(50)]
        public Guid CountryId { get; set; }
        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Gets or sets the zip
        /// </summary>
        [Display(Name ="Post Code")]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the vat number
        /// </summary>

        [Required]
        [StringLength(20)]
        [Display(Name ="VAT Registration Number")]
        public string VatRegNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer is active
        /// </summary>
        public bool IsActive { get; set; }

        [ForeignKey("PictureId")]
        public Picture Picture { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }



        //public override string ToString()
        //{
        //    return $"Customer(Code: {Code}, Name: {Name}, Address: {Address}, Phone No.: {PhoneNo})";
        //}
    }
}

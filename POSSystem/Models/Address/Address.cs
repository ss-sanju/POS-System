using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSSystem.Models.Address
{
    public class Address
    {
        [Key,Required, StringLength(20)]
        public Guid ID { get; set; }
        [Required, StringLength(00)]
        [Display(Name ="Address")]
        public string AddressLine { get; set; }
        [Required, StringLength(20)]
        public string City { get; set; }        
        [Required, StringLength(20)]
        [Display(Name = "Post Code")]
        public string Postal_Code { get; set; }
        [Required, StringLength(20)]
        public Guid CountryId { get; set; }
        [Required, StringLength(20)]
        [Phone]
        public string Phone1 { get; set; }
        [Required, StringLength(20)]
        [Phone]
        public string Phone2 { get; set; }
        [Required, StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}

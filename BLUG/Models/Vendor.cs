using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BLUG.Models
{
    [Bind(Exclude = "VendorId")]
    public class Vendor
    {
        [ScaffoldColumn(false)]
        public int VendorId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Name { get; set; }

        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [DisplayName("Contact Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhone { get; set; }

    }
}
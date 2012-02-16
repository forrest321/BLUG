using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace BLUG.Models
{
    [Bind(Exclude = "InstructorId")]
    public class Instructor
    {
        [ScaffoldColumn(false)]
        public int InstructorId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Vendor")]
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
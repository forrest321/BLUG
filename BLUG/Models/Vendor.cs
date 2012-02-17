using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BLUG.Models
{
    
    public class Vendor
    {
        
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

        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BLUG.Models
{
    
    public class ClassOffering
    {

        public int ClassOfferingId { get; set; }

        [Required]
        [DisplayName("Vendor")]
        public int VendorId { get; set; }

        [Required]
        [DisplayName("Instructor")]
        public int InstructorId { get; set; }

        [Required]
        [DisplayName("Course")]
        public int CourseId { get; set; }

        [Required]
        [DisplayName("Location")]
        public int LocationId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }


        public virtual Vendor Vendor { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Location Location { get; set; }
        public virtual Course Course { get; set; }
    
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BLUG.Models
{
    [Bind(Exclude = "CourseId")]
    public class Course
    {
        [ScaffoldColumn(false)]
        public int CourseId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace BLUG.Models
{
    
    public class Instructor
    {
        
        public int InstructorId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
    }
}
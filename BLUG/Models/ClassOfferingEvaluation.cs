using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLUG.Models
{
    public class ClassOfferingEvaluation
    {
        [Key]
        public int Id { get; set; }
        public int ClassOfferingId { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }

        public virtual List<ClassOffering> ClassOfferings { get; set; }
    }
}
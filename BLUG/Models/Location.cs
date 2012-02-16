using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BLUG.Models
{
    [Bind(Exclude="LocationId")]
    public class Location
    {
        [ScaffoldColumn(false)]
        public int LocationId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("Address 1")]
        [DataType(DataType.Text)]
        public string Address1 { get; set; }

        [DisplayName("Address 2")]
        [DataType(DataType.Text)]
        public string Address2 { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

        [DataType(DataType.Text)]
        public string State { get; set; }

        [DataType(DataType.Text)]
        public string Zip { get; set; }

        [DataType(DataType.Text)]
        public string Contact { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string ContactPhone { get; set; }
    }
}
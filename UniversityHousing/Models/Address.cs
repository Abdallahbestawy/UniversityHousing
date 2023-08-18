using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string CityName { get; set; }
        public int PostalCode { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}

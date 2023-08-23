using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class Faculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte FacultyId { get; set; }
        [Required,MaxLength(500)]
        public string FacultyName { get; set; }
        public virtual List<Student> Students { get; set; }
    
    }
}

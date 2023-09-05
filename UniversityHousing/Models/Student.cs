using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }
        public virtual User User { get; set; }  
       
        [Required,MaxLength (150)]
        public string StudentGrade { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        [ForeignKey("Faculty")]
        public byte facultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public byte studentLevel { get; set; }

        public virtual List<Booking> Bookings { get; set; }



    }
}

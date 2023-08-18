using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required,MaxLength(500)]
        public string FirstName { get; set; }
        [Required, MaxLength(500)]
        public int LastName { get; set; }
        [StringLength(11, MinimumLength = 11)]
        [RegularExpression(@"^\d+$", ErrorMessage = "must be numeric")]
        [Required]
        public string Phone { get; set; }
        [StringLength(14, MinimumLength = 14)]
        [RegularExpression(@"^\d+$")]
        [Required]
        public string NationalId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
        [Required,MaxLength (150)]
        public string StudentGrade { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public virtual List<Booking> Bookings { get; set; }



    }
}

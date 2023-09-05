using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UniversityHousing.Models;

namespace UniversityHousing.View_Model
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [Required, MaxLength(500)]
        public string FirstName { get; set; }
        [Required, MaxLength(500)]
        public string LastName { get; set; }
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
        [Required, MaxLength(150)]
        public string StudentGrade { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        [ForeignKey("Faculty")]
        public byte facultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public byte studentLevel { get; set; }
    }
}

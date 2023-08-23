using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace UniversityHousing.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int adminId { get; set; }
        [Required, MaxLength(500)]
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
        public virtual List<Request> Requests { get; set; }
    }
}

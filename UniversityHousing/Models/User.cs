﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityHousing.Models
{
    public class User
    {
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
        public virtual Student Student { get; set; }
        public virtual Admin Admin { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UniversityHousing.Models;

namespace UniversityHousing.View_Model
{
    public class AdminListVM
    {
        public int userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
    }
}

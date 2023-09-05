using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UniversityHousing.Models;

namespace UniversityHousing.View_Model
{
    public class StudentListViewModel
    {

        public int userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }
        public string NationalId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
        public string StudentGrade { get; set; }
        public string Address { get; set; }
        public string facultyName { get; set; }
        public byte studentLevel { get; set; }
    }
}

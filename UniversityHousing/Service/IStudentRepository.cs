using UniversityHousing.Models;
using UniversityHousing.View_Model;

namespace UniversityHousing.Service
{
    public interface IStudentRepository
    {
        List<StudentListViewModel> GetStudents();
        int CreateStudent(StudentViewModel student); 
        StudentListViewModel GetStudentById(int StudentId);
        StudentViewModel GetStudentByIdEdite(int StudentId);

        int UpdateStudent(int StudentId, StudentViewModel student);
    }
}

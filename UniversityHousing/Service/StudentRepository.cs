using Microsoft.EntityFrameworkCore;
using UniversityHousing.Models;
using UniversityHousing.View_Model;

namespace UniversityHousing.Service
{
    public class StudentRepository : IStudentRepository
    {
        private readonly HousingContext Context;

        public StudentRepository(HousingContext _housingContext)
        {
            Context = _housingContext;
        }
        public List<StudentListViewModel> GetStudents()
        {
            List<StudentListViewModel> students = Context.Students
                 .Include(a => a.Address)
                 .Include(f => f.Faculty)
                .Select(s => new StudentListViewModel
             {
                FirstName = s.User.FirstName,
                LastName = s.User.LastName,
                Email = s.User.Email,
                Phone = s.User.Phone,
                NationalId = s.User.NationalId,
                DateOfBirth = s.User.DateOfBirth,
                Gender = s.User.Gender,
                StudentGrade = s.StudentGrade,
                studentLevel = s.studentLevel,
                Address = s.Address.CityName,
                facultyName = s.Faculty.FacultyName
            })
            .ToList();
            return students;

        }
        public StudentListViewModel GetStudentById(int StudentId)
        {
            StudentListViewModel student = Context.Students
                .Include(a => a.Address)
                .Include(f => f.Faculty)
                .Where(s => s.StudentId == StudentId)
                .Select(s => new StudentListViewModel
                {
                    userId=s.User.userId,
                    FirstName = s.User.FirstName,
                    LastName = s.User.LastName,
                    Email = s.User.Email,
                    Phone = s.User.Phone,
                    NationalId = s.User.NationalId,
                    DateOfBirth = s.User.DateOfBirth,
                    Gender = s.User.Gender,
                    StudentGrade = s.StudentGrade,
                    studentLevel = s.studentLevel,
                    Address = s.Address.CityName,
                    facultyName = s.Faculty.FacultyName
                })
                .FirstOrDefault();

            return student;
        }


        public int CreateStudent(StudentViewModel student)
        {
            var user = new User
            {
                FirstName=student.FirstName,
                LastName=student.LastName,
                Email=student.Email,
                Phone=student.Phone,
                NationalId=student.NationalId,
                DateOfBirth=student.DateOfBirth,
                Gender=student.Gender
            };
            Context.users.Add(user);
            Context.SaveChanges();
            var studentEntity = new Student
            {
                userId=user.userId,
                AddressId=student.AddressId,    
                facultyId=student.facultyId,
                StudentGrade=student.StudentGrade,
                studentLevel=student.studentLevel
            };

            Context.Students.Add(studentEntity);  
            int raw=Context.SaveChanges();
            return raw;
        }

  

        public int UpdateStudent(int StudentId,StudentViewModel student)
        {
            var oldStudent = Context.Students.Include(u=>u.User).Where(s => s.StudentId == StudentId).FirstOrDefault();

            if (oldStudent != null)
            {
                oldStudent.studentLevel = student.studentLevel;
                oldStudent.StudentGrade = student.StudentGrade;
                oldStudent.facultyId = student.facultyId;
                oldStudent.AddressId = student.AddressId;

                if (oldStudent.User != null)
                {
                    oldStudent.User.FirstName = student.FirstName;
                    oldStudent.User.LastName = student.LastName; 
                    oldStudent.User.Email = student.Email;
                    oldStudent.User.Gender = student.Gender;
                    oldStudent.User.NationalId = student.NationalId;
                    oldStudent.User.Phone = student.Phone;
                    oldStudent.User.DateOfBirth = student.DateOfBirth;
                }

                int raw = Context.SaveChanges();
                return raw;
            }
            else
            {
                return 0; 
            }
        }

        public StudentViewModel GetStudentByIdEdite(int StudentId)
        {
            StudentViewModel student = Context.Students
                          .Include(a => a.Address)
                          .Include(f => f.Faculty)
                          .Where(s => s.StudentId == StudentId)
                          .Select(s => new StudentViewModel
                          {
                              StudentId=s.StudentId,
                              userId = s.User.userId,
                              FirstName = s.User.FirstName,
                              LastName = s.User.LastName,
                              Email = s.User.Email,
                              Phone = s.User.Phone,
                              NationalId = s.User.NationalId,
                              DateOfBirth = s.User.DateOfBirth,
                              Gender = s.User.Gender,
                              StudentGrade = s.StudentGrade,
                              studentLevel = s.studentLevel,
                              AddressId=s.AddressId,
                              facultyId=s.facultyId
                          })
                          .FirstOrDefault();

            return student;
        }
    }
}

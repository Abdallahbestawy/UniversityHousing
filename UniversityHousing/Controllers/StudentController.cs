using Microsoft.AspNetCore.Mvc;
using UniversityHousing.Models;
using UniversityHousing.Service;
using UniversityHousing.View_Model;

namespace UniversityHousing.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentService;
        private readonly HousingContext context;

        public StudentController(IStudentRepository _studentRepository,HousingContext _context)
        {
            studentService = _studentRepository;
            context = _context; 
        }
        public IActionResult Index()
        {
            return View(studentService.GetStudents().ToList());
        }
        public IActionResult DetailsStudent(int Id)
        {
            return View(studentService.GetStudentById(Id));
        }
        public IActionResult AddStudent()
        {
            ViewBag.address= context.Addresses.ToList();
            ViewBag.fact = context.Facultys.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentViewModel student)
        {
            studentService.CreateStudent(student);
            return RedirectToAction(nameof(Index));
            //if (ModelState.IsValid)
            //{
            //    studentService.CreateStudent(student);
            //    return RedirectToAction(nameof(Index));
            //}
            //else
            //{
            //    return View(student);
            //}
        }
        public IActionResult Edit(int Id)
        {
            ViewBag.address = context.Addresses.ToList();
            ViewBag.fact = context.Facultys.ToList();
            return View(studentService.GetStudentByIdEdite(Id));
        }
        [HttpPost]
        public IActionResult Edit(int Id,StudentViewModel student)
        {
            studentService.UpdateStudent(Id,student);
            return RedirectToAction(nameof(Index));

        }
    }
}

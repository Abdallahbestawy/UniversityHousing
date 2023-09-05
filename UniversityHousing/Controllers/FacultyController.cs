using Microsoft.AspNetCore.Mvc;
using UniversityHousing.Service;

namespace UniversityHousing.Controllers
{
    public class FacultyController : Controller
    {
        private readonly IFacultyRepository facultyService;
        public FacultyController(IFacultyRepository facultyRepository)
        {
            facultyService = facultyRepository;
        }
        public IActionResult Index()
        {
            return View(facultyService.GettAllFaculty().ToList());
        }
    }
}

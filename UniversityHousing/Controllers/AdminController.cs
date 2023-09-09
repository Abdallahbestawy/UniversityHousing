using Microsoft.AspNetCore.Mvc;
using UniversityHousing.Models;
using UniversityHousing.Service;
using UniversityHousing.View_Model;

namespace UniversityHousing.Controllers
{
    public class AdminController : Controller
    {
        public readonly IAdminRepository adminRepository;
        public readonly HousingContext context;
        public AdminController(IAdminRepository _adminRepository, HousingContext _context)
        {
            adminRepository = _adminRepository;
            context = _context;
        }
        public IActionResult Index()
        {
            return View(adminRepository.GetAll().ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AdminVM admin)
        {
            adminRepository.Create(admin);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(adminRepository.GetById(id));
        }

        public IActionResult Edit(int id)
        {
            return View(adminRepository.Edit(id));
        }

        [HttpPost]
        public IActionResult Edit(int id,AdminVM admin)
        {
            adminRepository.Update(id, admin);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            adminRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

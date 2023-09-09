using Microsoft.AspNetCore.Mvc;
using UniversityHousing.Models;
using UniversityHousing.Service;

namespace UniversityHousing.Controllers
{
    public class RoomController : Controller
    {
        public readonly IRoomRepository roomRepository;

        public RoomController(IRoomRepository _roomRepository)
        {
            roomRepository = _roomRepository;
        }
        public IActionResult Index()
        {
            return View(roomRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Room room)
        {
            roomRepository.Create(room);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(roomRepository.GetById(id));
        }

        public IActionResult Delete(int id)
        {
            roomRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(roomRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(int id,Room room)
        {
            roomRepository.Update(id,room);
            return RedirectToAction("Index");
        }
    }
}

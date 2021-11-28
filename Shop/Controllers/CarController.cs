using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<ViewResult> Index()
        {
            ViewBag.Title = "Cars";
            return View(await _carRepository.GetAllAsync());
        }

        public async Task<ActionResult> Create()
        {
            ViewBag.Categories = new SelectList(await _categoryRepository.GetAllAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Car model)
        {
            await _carRepository.AddAsync(model);
            return View();
        }
    }
}

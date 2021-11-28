using Microsoft.AspNetCore.Mvc;
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
            var cars = await _carRepository.GetAllAsync();
            return View(cars);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}

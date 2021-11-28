using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;

namespace Shop.Controllers
{
    public class CarController : Controller
    {
        private readonly IMockCarRepository _carRepository;
        private readonly IMockCategoryRepository _categoryRepository;

        public CarController(IMockCarRepository carRepository, IMockCategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Cars";
            var cars = _carRepository.GetAll();
            return View(cars);
        }
    }
}

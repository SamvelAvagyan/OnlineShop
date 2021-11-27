using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockCar : ICarRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategory();

        public IEnumerable<Car> GetAll()
        {
            return new List<Car>
            {
                new Car { Name = "BMW", Category = _categoryRepository.GetAll().Last() },
                new Car { Name = "Tesla", Category = _categoryRepository.GetAll().First() }
            };
        }

        public Car GetCar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetFavouriteCars()
        {
            throw new NotImplementedException();
        }
    }
}

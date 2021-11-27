using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {
            return new List<Category>
            {
                new Category{ Name = "ElectroCars", Description = "Modern type of cars"},
                new Category{ Name = "ClassicCars", Description = "Cars with fuel etc."}
            };
        }
    }
}

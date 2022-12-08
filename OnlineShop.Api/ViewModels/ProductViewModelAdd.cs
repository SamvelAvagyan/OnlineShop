using OnlineShop.Repository.Models;

namespace OnlineShop.Api.ViewModels
{
    public class ProductViewModelAdd
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}

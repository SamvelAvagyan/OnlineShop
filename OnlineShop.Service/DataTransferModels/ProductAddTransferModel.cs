using OnlineShop.Repository.Models;

namespace OnlineShop.Service.DataTransferModels
{
    public class ProductAddTransferModel
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Count { get; set; }
    }
}

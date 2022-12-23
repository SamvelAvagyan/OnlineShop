namespace OnlineShop.Repository.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}

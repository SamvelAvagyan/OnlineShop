using System.Collections.Generic;

namespace OnlineShop.Repository.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
}

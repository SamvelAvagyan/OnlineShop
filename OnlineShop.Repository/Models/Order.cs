using System;
using System.Collections.Generic;

namespace OnlineShop.Repository.Models
{
    public class Order : BaseModel
    {
        public User? User { get; set; }
        public List<ProductOrder> Products { get; set; }
        public string Address { get; set; }
        public bool IsCashless { get; set; }
        public DateTime Date { get; set; }
    }
}

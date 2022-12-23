namespace OnlineShop.Repository.Models
{
    public class ProductOrder : BaseModel
    {
        public Product Product { get; set; }
        public int Count { get; set; }
        public int TotalSum
        {
            get
            {
                return Count * Product.Price;
            }
        }
    }
}

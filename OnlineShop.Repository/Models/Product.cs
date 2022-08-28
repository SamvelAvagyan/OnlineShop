namespace OnlineShop.Repository.Models
{
    public enum Category
    {
        Clothing,
        Shoes,
        ConsumerElectronics,
        Books,
        Cosmetics,
        BagsAndAccessories,
        FoodAndDrinks,
        Furniture,
        Sports,
        HouseholdAppliances,
        Toys
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Count { get; set; }
    }
}

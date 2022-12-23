namespace OnlineShop.Repository.Models
{
    public enum Role
    {
        Buyer,
        Admin
    }

    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string CardNumber { get; set; }
        public Role Role { get; set; } 
        public string Password { get; set; }
    }
}

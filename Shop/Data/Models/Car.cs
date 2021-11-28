namespace Shop.Data.Models
{
    public class Car : BaseModel
    {
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public ushort Price { get; set; }
        public string ImgUrl { get; set; }
        public bool IsFavourite { get; set; }
        public int Available { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

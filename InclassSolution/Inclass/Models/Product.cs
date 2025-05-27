namespace Inclass.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Catagory Catagory { get; set; }
        public int CatagoryId { get; set; }
        public List<OrderItem> OrderItemList { get; set; }
        public List<Review> ReviewList { get; set; }

    }
}

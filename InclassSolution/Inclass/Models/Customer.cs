namespace Inclass.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactInfo { get; set; }

        public List<PaymentInformation> PaymentInformationList { get; set; }
        public List<Order> OrderList { get; set; }
        public List<ShippingAddress> ShippingAddressList { get; set; }
        public List<Review> ReviewList { get; set; }
    }
}

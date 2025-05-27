namespace Inclass.Models
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}

namespace Inclass.Models
{
    public class PaymentInformation
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public int CardNumber { get; set; }
        public int CVV { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}

namespace Frutiva.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCardNumber { get; set; }
        public virtual ICollection<Bowl> Bowls { get; set; }
        public double Total { get; set; }
    }
    public enum PaymentMethod
    {
        CreditCard, InStore
    }
}
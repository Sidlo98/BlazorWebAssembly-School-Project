namespace WebShop.Models
{
    public class Order
    {
        public int UserId { get; set; }
        public string Status { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}

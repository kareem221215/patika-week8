namespace Basic_MVC.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> orders { get; set; }
    }
}

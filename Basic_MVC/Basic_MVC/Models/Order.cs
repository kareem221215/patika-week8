namespace Basic_MVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Product_name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}

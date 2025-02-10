using Basic_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {

        
        public IActionResult Index()
        {
            var Customer = new Customer
            {
                Id = 1,
                First_name = "kareem",
                Last_name = "alsayed",
                Email = "kareem.s.sleman@gmail.com"
            };
            var orders = new List<Order>
            {
                new Order { Id = 101, Product_name = "Laptop", price = 1200.50m, quantity = 1 },
                new Order { Id = 102, Product_name = "Mouse", price = 25.99m, quantity = 2 },
                new Order { Id = 103, Product_name = "Keyboard", price = 45.00m, quantity = 1 }
            };
            var viewModel = new CustomerOrderViewModel
            {
                Customer = Customer,
                orders = orders
            };

            
            return View(viewModel);
        }
    }
}

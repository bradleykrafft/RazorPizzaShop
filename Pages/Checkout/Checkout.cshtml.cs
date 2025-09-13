using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Data;
using RazorPizzaShop.Migrations;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice   { get; set; }
        public string ImageTitle { get; set; }


        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // get pizza name from title of pizza
        public void OnGet()
        {
            
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "CustomPizza";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            RazorPizzaShop.Models.PizzaOrder pizzaOrder = new RazorPizzaShop.Models.PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;            
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();


        }
    }
}

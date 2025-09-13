using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using RazorPizzaShop.Data;
using RazorPizzaShop.Models;


namespace RazorPizzaShop.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet() 
        {
            try { 
            PizzaOrders = _context.PizzaOrders.ToList();
                }
            catch (SqlException ex)
            {            
                
                    // Log the exception (you can use a logging framework here)
                    Console.WriteLine($"An error occurred while retrieving pizza orders: {ex.Message}");
                    // Optionally, you can set an error message to display in the UI
                    // ErrorMessage = "An error occurred while loading the orders.";
                
            }
        }
    }
}

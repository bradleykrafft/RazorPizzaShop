using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; } 
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;          

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.WhiteSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if(Pizza.ItalianSausage) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Beef) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});

        }

    }
}

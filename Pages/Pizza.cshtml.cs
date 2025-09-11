using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Models;
using System.Security.Cryptography.X509Certificates;

namespace RazorPizzaShop.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PiazzaName = "Margerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4,
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PiazzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4,
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PiazzaName = "Hawaiian",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Pineapple = true,
                Ham= true,
                FinalPrice = 16,
            },
            new PizzasModel()
            {
                ImageTitle = "Carbonara",
                PiazzaName = "Carbonara",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                FinalPrice = 6,
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PiazzaName = "MeatFeast",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Ham=true,
                Beef=true,
                ItalianSausage=true,
                FinalPrice = 8,
            },
            new PizzasModel()
            {
                ImageTitle = "Mushroom",
                PiazzaName = "Mushroom",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                FinalPrice = 6,
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PiazzaName = "Pepperoni",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Pineapple = true,
                FinalPrice = 6,
            },
            new PizzasModel()
            {
                ImageTitle = "Seafood",
                PiazzaName = "Seafood",
                BasePrice = 2,
                WhiteSauce = true,
                Cheese = true,
                Tuna = true,
                FinalPrice = 5,
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                PiazzaName = "Vegetarian",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                Pineapple = true,
                FinalPrice = 12,
            },

        };

        public void OnGet()
        {
        }
    }
}

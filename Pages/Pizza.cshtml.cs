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
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4,
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4,
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
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
                PizzaName = "Carbonara",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                FinalPrice = 6,
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
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
                PizzaName = "Mushroom",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,
                FinalPrice = 6,
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Pineapple = true,
                FinalPrice = 6,
            },
            new PizzasModel()
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 2,
                WhiteSauce = true,
                Cheese = true,
                Tuna = true,
                FinalPrice = 5,
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
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

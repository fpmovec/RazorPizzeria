using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageName="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce = true,
                TotalPrice = 4
            },
            new PizzasModel()
            {
                ImageName="Bolognese",
                PizzaName="Bolognese",
                BasePrice =2,
                TomatoSauce=true,
                Beef=true,
                TotalPrice = 5
            },
             new PizzasModel()
            {
                ImageName="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce = true,
                TotalPrice = 4
            },
            new PizzasModel()
            {
                ImageName="Carbonara",
                PizzaName="Carbonara",
                BasePrice =2,
                TomatoSauce=true,
                Beef=true,
                TotalPrice = 5
            },
             new PizzasModel()
            {
                ImageName="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce = true,
                TotalPrice = 4
            },
            new PizzasModel()
            {
                ImageName="Mushroom",
                PizzaName="Mushroom",
                BasePrice =2,
                TomatoSauce=true,
                Beef=true,
                TotalPrice = 5
            },
             new PizzasModel()
            {
                ImageName="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce = true,
                TotalPrice = 4
            },
            new PizzasModel()
            {
                ImageName="Seafood",
                PizzaName="Seafood",
                BasePrice =2,
                TomatoSauce=true,
                Beef=true,
                TotalPrice = 5
            },
             new PizzasModel()
             {
                ImageName="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce = true,
                TotalPrice = 4
             }
        };
        public void OnGet()
        {
        }
    }
}

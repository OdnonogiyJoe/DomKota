using System;
using System.Collections.Generic;
using System.Linq;
using DomKota.Models;
using System.Threading.Tasks;

namespace DomKota
{
    public class SampleData
    {
        public static void Initialize(DishesContext context)
        {
            if (!context.Menus.Any())
            {
                context.Menus.AddRange(
                    new Menu
                    {
                        Name = "iPhone 8",
                        Description = "Apple",
                        Price = 600
                    },
                    new Menu
                    {
                        Name = "Samsung Galaxy Edge",
                        Description = "Samsung",
                        Price = 550
                    },
                    new Menu
                    {
                        Name = "Pixel 3",
                        Description = "Google",
                        Price = 500
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}

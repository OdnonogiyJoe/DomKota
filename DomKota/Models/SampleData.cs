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
                        Name = "Чикибамбони с яйцом",
                        Description = "Хорошо поджаренный стейк с яйцом, картошкой и рисом, под фирменным соусом",
                        Price = 10
                    },
                    new Menu
                    {
                        Name = "Чирэветки в кляре под сырным одеялом",
                        Description = "Пойманные в недрах Тихого океана креветки, придавшиеся кляру, с рисом под сырным одеялом",
                        Price = 20
                    },
                    new Menu
                    {
                        Name = "Итальянцы под пастой",
                        Description = "Взрощенная на бескрайних полях пшеница, измельченная в муку и объединившаяся с водой, обратилась в спагетти",
                        Price = 15
                    },
                    new Menu
                    {
                        Name = "Властелин колец",
                        Description = "Приятное дополнение к осежающему дюшесу",
                        Price = 10
                    },
                    new Menu
                    {
                        Name = "Шоколадное затмение",
                        Description = "Затмит печали, горести, уныния",
                        Price = 10
                    },
                    new Menu
                    {
                        Name = "Царь горы",
                        Description = "winner winner chicken dinner",
                        Price = 10
                    },
                    new Menu
                    {
                        Name = "Дюшес 0,5л",
                        Description = "Бодрящий напиток",
                        Price = 3
                    },
                    new Menu
                    {
                        Name = "Дюшес 1л",
                        Description = "Бодрящий напиток",
                        Price = 5
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}

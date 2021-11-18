using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomKota.Models
{
    public class DishesContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DishesContext(DbContextOptions<DishesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

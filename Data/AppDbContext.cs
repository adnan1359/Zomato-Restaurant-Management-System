using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zomato.Models;

namespace Zomato.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants{ get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Server=localhost;Database=zomatodb;User=root;Password=root;";
                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 22)));
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zomato.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurants { get; set; } // Restaurant Navigation Property
    }
}

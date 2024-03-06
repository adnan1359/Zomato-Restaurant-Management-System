using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zomato.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }
        public string CuisineType { get; set; }


        // Navigation Properties

        public ICollection<Menu> Menus { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}


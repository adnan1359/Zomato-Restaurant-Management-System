using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zomato.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }


        public int RestaurantId { get; set; }
        public Restaurant Restaurants { get; set; } // Restaurant Navigation Property

        public ICollection<OrderItem> OrderItems { get; set; }

    }
}

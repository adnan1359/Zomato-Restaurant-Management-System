using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zomato.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public int OrderId { get; set; }
        public Order Orders { get; set; }
    }
}

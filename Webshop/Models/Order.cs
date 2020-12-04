using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

    }
}

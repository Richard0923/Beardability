using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Order
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        public DateTime Date { get; set; }

        public int TotalPrice { get; set; }

        public string ShipppingAddress { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

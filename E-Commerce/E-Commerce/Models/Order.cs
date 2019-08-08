using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Order
    {
        public int ID { get; set; }

        public string CustomerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int TotalPrice { get; set; }

        public string ShipppingAddress { get; set; }

        //Navagation 
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

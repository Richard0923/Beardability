using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class OrderItem
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public int OrderID { get; set; }

        public int Quanity { get; set; }

        public int TotalItemPrice { get; set; }
    }
}

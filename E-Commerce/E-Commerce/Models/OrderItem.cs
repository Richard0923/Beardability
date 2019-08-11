using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class OrderItem
    {
        public int ProductID { get; set; }

        public int OrderID { get; set; }

        public int Quanity { get; set; }

        public int TotalItemPrice { get; set; }

        //Navagation 
        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Basket 
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}

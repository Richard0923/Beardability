using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    /// <summary>
    /// Model for our Basket Table
    /// </summary>
    public class Basket 
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}

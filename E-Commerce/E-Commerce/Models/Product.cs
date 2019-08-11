using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    /// <summary>
    /// Product Model for the DB
    /// </summary>
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Sku { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        // Nav properties 
        public ICollection<BasketItem> BasketItem { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
    }
}

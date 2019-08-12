using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static E_Commerce.Models.BasketItem;


namespace E_Commerce.Models.ViewModels
{
    /// <summary>
    /// View Model for Basket detail
    /// </summary>
    public class BasketDetailViewModel
    {
        public int ID { get; set; }
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quanity { get; set; }
    }
}

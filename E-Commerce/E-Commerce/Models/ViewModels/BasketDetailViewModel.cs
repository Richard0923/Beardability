using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static E_Commerce.Models.BasketItem;


namespace E_Commerce.Models.ViewModels
{
    public class BasketDetailViewModel
    {
        public int ID { get; set; }
        public int BasketID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; }
        public string Sku { get; }
        public decimal Price { get; }
        public string Image { get; }
        public int Quanity { get; set; }
    }
}

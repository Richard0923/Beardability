using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class BasketItem
    {
        public int ID { get; set; }

        //Foreign Key of the Basket associated with
        [ForeignKey("Basket")]
        public int BasketID { get; set; }

        //Foreign Key of Product to be saved in the DB
        [ForeignKey("Product")]
        public int ProductID { get; set; }

        //Number of Items desired by the user to buy
        public int Quanity { get; set; }
    }
}

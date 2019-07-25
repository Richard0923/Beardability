using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Basket 
    {
        //[ForeignKey("UserID")]
        public int ID { get; set; }

        public string Email { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}

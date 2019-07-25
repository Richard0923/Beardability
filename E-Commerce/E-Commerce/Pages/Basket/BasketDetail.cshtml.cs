using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Basket
{
    public class BasketDetailModel : PageModel
    {

        private readonly IInventory _context;
        public IBasket _basketList;

        public BasketDetailModel(IInventory context, IBasket basketList)
        {
            _context = context;
            _basketList = basketList;
        }

        public ICollection<BasketItem> BasketItems { get; }

        [BindProperty]
        public BasketItem BasketItem { get; set; }

        public async Task OnGet()
        {
            List<BasketItem> basketItems = await _basketList.GetAllBasketItems();
        }


    }
}
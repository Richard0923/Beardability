using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Components
{
    public class Basket : ViewComponent
    {
        private IBasket _basket;

        public Basket(IBasket basket)
        {
            _basket = basket;
        }

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var items = await _basket.GetAllBasketItems();
            var results = items.OrderByDescending(x => x.BasketID)
                                .Take(number);
            return View(results);
        }
    }
}

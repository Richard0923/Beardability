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
        private IInventory _inventory;

        public Basket(IInventory inventory)
        {
            _inventory = inventory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var items = await _inventory.GetAllBasketItems();
            var results = items.OrderByDescending(x => x.ID)
                                .Take(number);
            return View(results);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Shop
{
    public class ShoppingDetailModel : PageModel
    {

        private readonly IInventory _context;


        public ShoppingDetailModel(IInventory context)
        {
            _context = context;
        }

        public Product Beard { get; set; }
        public async Task OnGet(int id)
        {
            Beard = await _context.GetItemByIDAsync(id);
        }
    }
}
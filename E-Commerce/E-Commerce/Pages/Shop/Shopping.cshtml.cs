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
    /// <summary>
    /// Adds functionallity to the Shopping page
    /// </summary>
    public class ShoppingModel : PageModel
    {
        private readonly IInventory _context;


        public ShoppingModel(IInventory context)
        {
            _context = context;
        }

        public List<Product> Beards { get; set; }

        /// <summary>
        /// When the page gets render it grabs a list of all the Products in the DBs.
        /// </summary>
        /// <returns></returns>
        public async Task OnGet()
        {
           Beards =  await _context.GetAllItemsAsync();
   
        }
    }
}
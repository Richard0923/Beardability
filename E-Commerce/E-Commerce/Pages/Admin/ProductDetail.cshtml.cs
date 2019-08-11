using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Admin
{
    public class ProductDetailModel : PageModel
    {
        [Authorize]
        public class BasketDetailModel : PageModel
        {

            public IInventory _context;

            public BasketDetailModel(IInventory context)
            {
                _context = context;
            }

            [BindProperty]
            public Product Beard { get; set; }
           
            /// <summary>
            /// Retrieve product by it's ID.
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public async Task OnGet(int id)
            {
                Beard = await _context.GetItemByIDAsync(id);
            }

        }
    }
}
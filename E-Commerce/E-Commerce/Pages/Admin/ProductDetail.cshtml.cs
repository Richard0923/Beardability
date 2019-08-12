﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Models.Interfaces;
using E_Commerce.Models.Services;
using E_Commerce.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Storage.Blob;

namespace E_Commerce.Pages.Admin
{
    [Authorize(Policy = "AdminOnly")]
    public class ProductDetailModel : PageModel
    {

        public IInventory _context;
        public IBlobManager _blob;

        public ProductDetailModel(IInventory context, IBlobManager blobManager)
        {
            _context = context;
            _blob = blobManager;
        }

        [FromRoute]
        public int? Id { get; set; }

        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }
        public Blob BlobImage { get; set; }

        /// <summary>
        /// Retrieve product by it's ID.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task OnGet(int id)
        {
            Product = await _context.GetItemByIDAsync(id) ?? new Product();
        }

        /// <summary>
        /// Update record of product with new details
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost(BlobViewModel BlobVM)
        {
            var idProduct = Request.Form["product"];
            int productid = Convert.ToInt32(idProduct);
            
            Product product = await _context.GetItemByIDAsync(productid) ?? new Product();

            string formName = Request.Form["name"];
            product.Name = formName;
            string formSku = Request.Form["sku"];
            product.Sku = Product.Sku;
            var formPrice = Request.Form["price"];
            decimal price = Convert.ToDecimal(formPrice); 
            product.Price = Product.Price;
            string formDescription = Request.Form["description"];
            product.Description = Product.Description;
            string formImage = Request.Form["image"];
            

            if (productid == 0)
            {
                var filePath = Path.GetTempFileName();

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await BlobVM.Image.CopyToAsync(stream);
                };

                var container = await _blob.GetContainer("products");

                // upload the image
                _blob.UploadFile(container, BlobVM.Image.FileName, filePath);
                CloudBlob blob = await _blob.GetBlob(BlobVM.Image.FileName, container.Name);
                string URL = blob.Uri.ToString();

                product.Image = URL;
                await _context.CreateItem(product);
            }
            else
            {

                await _context.UpdateItemAsync(productid);
            }

            return RedirectToPage("/ProductManager");
        }

        /// <summary>
        /// Removes record of product from db
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPostDelete()
        {
            var idProduct = Request.Form["deleteproduct"];
            int productid = Convert.ToInt32(idProduct);

            Product product = await _context.GetItemByIDAsync(productid);

            await _context.DeleteItem(productid);
            return RedirectToPage();
        }

        
    }
}
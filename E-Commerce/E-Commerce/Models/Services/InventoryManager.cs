using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    /// <summary>
    /// Inventory service that adds functionallity to the IInventory interface.
    /// </summary>
    public class InventoryManager : IInventory

    {
        private ECommDbContext _context;

        public InventoryManager(ECommDbContext context)
        {
            _context = context;
        }

        public async Task CreateItem(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            Product product = await GetItemByIDAsync(id);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllItemsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetItemByIDAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(a => a.ID == id);
        }

        public async Task UpdateItemAsync(int id)
        {
            Product product = await GetItemByIDAsync(id);

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task AddBasketItem(BasketItem basketItem)
        {
            _context.BasketItems.Add(basketItem);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Basket> FindBasketID(string email)
        {
           var basketEmail = _context.Baskets.Where(e => e.Email == email);
            return basketEmail;
        }

    }
}

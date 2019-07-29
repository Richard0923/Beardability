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

        public Task CreateItem(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllItemsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetItemByIDAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(a => a.ID == id);
        }

        public Task UpdateItemAsync(Product product)
        {
            throw new NotImplementedException();
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

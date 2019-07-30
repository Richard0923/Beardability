using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class BasketManager : IBasket
    {
        private ECommDbContext _context;

        public BasketManager(ECommDbContext context)
        {
            _context = context;
        }

        public async Task CreateBasketItem(BasketItem basketItem)
        {
            _context.BasketItems.Add(basketItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBasketItem(int basketItemId)
        {
            BasketItem basketItem = await GetBasketItemById(basketItemId);
            _context.BasketItems.Remove(basketItem);

            await _context.SaveChangesAsync();
        }

        public async Task<List<BasketItem>> GetAllBasketItems()
        {
            return await _context.BasketItems.ToListAsync();
        }

        public async Task<BasketItem> GetBasketItemById(int id)
        {
            return await _context.BasketItems.FindAsync(id);
        }

        public async Task<BasketItem> GetBasketById(int id)
        {
            return await _context.BasketItems.FindAsync(id);
        }

        public async Task UpdateBasketItem(BasketItem basketItem)
        {
            _context.BasketItems.Update(basketItem);
            await _context.SaveChangesAsync();
        }

       public Basket FindBasketID(string email)
        {
            Basket basket = _context.Baskets.FirstOrDefault(e => e.Email == email);
            return basket;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

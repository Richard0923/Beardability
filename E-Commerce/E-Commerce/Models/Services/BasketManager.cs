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
            BasketItem basketItem = await GetBasketById(basketItemId);
            _context.BasketItems.Remove(basketItem);

            await _context.SaveChangesAsync();
        }

        public async Task<List<BasketItem>> GetAllBasketItems()
        {
            return await _context.BasketItems.ToListAsync();
        }

        public Task<BasketItem> GetBasketById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBasketItems(BasketItem basketItem)
        {
            throw new NotImplementedException();
        }

       public Basket FindBasketID(string email)
        {
            Basket basket = _context.Baskets.FirstOrDefault(e => e.Email == email);
            return basket;
        }
    }
}

using E_Commerce.Data;
using E_Commerce.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Services
{
    public class InventoryManager : IInventory

    {
        private ApplicationDbContext _context;

        public InventoryManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateItem(InventoryItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryItem>> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<InventoryItem> GetItemByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(InventoryItem item)
        {
            throw new NotImplementedException();
        }
    }
}

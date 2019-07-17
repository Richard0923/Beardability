using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IInventory
    {
        /// <summary>
        /// Creates a new Inventory Item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task CreateItem(InventoryItem item);

        /// <summary>
        /// Selects an individual Inventory Item
        /// </summary>
        /// <param name="id">ID of the Item to be selected</param>
        /// <returns></returns>
        Task<InventoryItem> GetItemByIDAsync(int id);

        /// <summary>
        /// Creates a list of all the Inventory Items
        /// </summary>
        /// <returns></returns>
        Task<List<InventoryItem>> GetAllItemsAsync();

        /// <summary>
        /// Updates an Inventory Item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task UpdateItemAsync(InventoryItem item);

        /// <summary>
        /// Removes an Inventory Item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteItem(int id);


    }
}

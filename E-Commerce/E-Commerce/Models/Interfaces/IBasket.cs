using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IBasket
    {
        /// <summary>
        /// Creates a new Basket item and saves it to the database.
        /// </summary>
        /// <param name="basketItem"></param>
        /// <returns></returns>
        Task CreateBasketItem(BasketItem basketItem);

        /// <summary>
        /// Finds the BasketItem by the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<BasketItem> GetBasketById(int id);

        /// <summary>
        /// Grabs all the basket items in the database and converts them into a list.
        /// </summary>
        /// <returns></returns>
        Task<List<BasketItem>> GetAllBasketItems();

        /// <summary>
        /// Update the basket item being given 
        /// </summary>
        /// <param name="basketItem"></param>
        /// <returns></returns>
        Task UpdateBasketItems(BasketItem basketItem);

        /// <summary>
        /// Deletes the Basket items by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteBasketItem(int id);

        Basket FindBasketID(string email);
    }
}

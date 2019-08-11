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
        Task<BasketItem> GetBasketItemById(int basketId, int productId);

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
        Task UpdateBasketItem(BasketItem basketItem);

        /// <summary>
        /// Deletes the Basket items by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteBasketItem(BasketItem basketItem);

        /// <summary>
        /// Finds the basket associated with the email given 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Returns the Basket with the email given</returns>
        Task<Basket> FindBasketID(string email);

        /// <summary>
        /// Saves Changes async
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();
    }
}

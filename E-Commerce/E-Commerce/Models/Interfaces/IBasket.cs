using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    /// <summary>
    /// Interface for Basket items.
    /// </summary>
    public interface IBasket
    {
        /// <summary>
        /// Creates a new Basket item and saves it to the database.
        /// </summary>
        /// <param name="basketItem"></param>
        /// <returns>Returns a async task</returns>
        Task CreateBasketItem(BasketItem basketItem);

        /// <summary>
        /// Finds the BasketItem by the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns an async task of BasketItem</returns>
        Task<BasketItem> GetBasketById(int id);

        /// <summary>
        /// Grabs all the basket items in the database and converts them into a list.
        /// </summary>
        /// <returns>Returns an async list of BasketItems</returns>
        Task<List<BasketItem>> GetAllBasketItems();

        /// <summary>
        /// Update the basket item being given 
        /// </summary>
        /// <param name="basketItem"></param>
        /// <returns>Returns a async task</returns>
        Task UpdateBasketItem(BasketItem basketItem);

        /// <summary>
        /// Deletes the Basket items by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a async task</returns>
        Task DeleteBasketItem(int id);

        /// <summary>
        /// Finds the Basket ID associated with that user by their email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Returns a Basket object</returns>
        Basket FindBasketID(string email);
    }
}

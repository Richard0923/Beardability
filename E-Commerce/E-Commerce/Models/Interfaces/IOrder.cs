using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models.Interfaces
{
    public interface IOrder
    {
        Task CreateOrder();

        Task UsersOrders();

        Task LastOrders();
    }
}

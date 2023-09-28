using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Abstractions;
using TestTask.DataBase.Entities;

namespace TestTask.Business.ServicesImplementation
{
    public class OrderService : IOrderService
    {
        public Task<List<Order>> GetAllOrdersWithNumberOfProductsMoreThenTen()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderWithMaxPrice()
        {
            throw new NotImplementedException();
        }
    }
}

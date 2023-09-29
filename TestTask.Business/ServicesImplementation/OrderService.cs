using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Abstractions;
using TestTask.Data.Abstractions;
using TestTask.DataBase.Entities;
using TestTask.DataBase.Enums;

namespace TestTask.Business.ServicesImplementation
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Order> GetOrderWithMaxPrice()
        {
            // В данном случае у нас два заказа с максимальной ценой - Id=9 и Id=15.
            // Поскольку в условии задачи указано вернуть только один заказ, удовлетворяющий условию,
            // без уточнений, что делать, если их будет несколько,
            // имплементацию данного варианта развития событий я добавлять не стал.
            var orderWithMaxPrice = await _unitOfWork.Orders
                .Get()
                .AsNoTracking()
                .OrderByDescending(order => order.Price)
                .FirstOrDefaultAsync();

            if (orderWithMaxPrice != null)
            {
                return orderWithMaxPrice;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Order>?> GetAllOrdersWithNumberOfProductsMoreThenTen()
        {
            var orders = await _unitOfWork.Orders
                .Get()
                .AsNoTracking()
                .Where(order => order.Quantity > 10)
                .Select(order => order)
                .ToListAsync();


            if (orders.Any())
            {
                return orders;
            }
            else
            {
                return null;
            }
        }
    }
}

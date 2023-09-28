using TestTask.DataBase.Entities;

namespace TestTask.Core.Abstractions
{
    public interface IOrderService
    {
        Task<Order> GetOrderWithMaxPrice();

        Task<List<Order>> GetAllOrdersWithNumberOfProductsMoreThenTen();
    }
}

using TestTask.DataBase.Entities;

namespace TestTask.Core.Abstractions
{
    public interface IUserService
    {
        Task<User> GetUserWithMaxNumberOfOrders();
        Task<List<User>> GetAllInactiveUsers();
    }
}

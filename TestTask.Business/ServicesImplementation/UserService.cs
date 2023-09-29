using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestTask.Core.Abstractions;
using TestTask.Data.Abstractions;
using TestTask.DataBase.Entities;
using TestTask.DataBase.Enums;

namespace TestTask.Business.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<User?> GetUserWithMaxNumberOfOrders()
        {
            var userWithMaxOrders = await _unitOfWork.Users
                .Get()
                .AsNoTracking()
                .Include(user => user.Orders)
                .OrderByDescending(user => user.Orders.Count)
                .FirstOrDefaultAsync();

            if (userWithMaxOrders != null)
            {
                return userWithMaxOrders;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<User>?> GetAllInactiveUsers()
        {
            var users = await _unitOfWork.Users
                .Get()
                .AsNoTracking()
                .Where(user => user.Status.Equals((int)UserStatus.Inactive))
                .Select(user => user)
                .ToListAsync();

            if (users.Any())
            {
                return users;
            }
            else
            {
                return null;
            }
        }
    }
}

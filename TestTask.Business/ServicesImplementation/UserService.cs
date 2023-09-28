using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Abstractions;
using TestTask.Data.Abstractions;
using TestTask.DataBase.Entities;

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

        public async Task<List<User>> GetAllInactiveUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserWithMaxNumberOfOrders()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Data.Abstractions;
using TestTask.Data.Abstractions.Repositories;
using TestTask.DataBase;
using TestTask.DataBase.Entities;

namespace TestTask.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public IRepository<User> Users { get; }
        public IRepository<Order> Orders { get; }

        public UnitOfWork(ApplicationDbContext dbContext, IRepository<User> users, 
            IRepository<Order> orders)
        {
            _dbContext = dbContext;
            Users = users;
            Orders = orders;
        }

        public async Task<int> CommitAsync()
        {
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }
    }
}

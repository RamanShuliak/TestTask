using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TestTask.Data.Abstractions.Repositories;
using TestTask.DataBase.Entities;

namespace TestTask.Data.Abstractions
{
    public interface IUnitOfWork
    {
        public IRepository<User> Users { get; }
        public IRepository<Order> Orders { get; }

        Task<int> CommitAsync();
    }
}

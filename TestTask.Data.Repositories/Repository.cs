using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Data.Abstractions.Repositories;
using TestTask.DataBase.Entities;

namespace TestTask.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public virtual IQueryable<T>? Get()
        {
            var entities = _dbSet
                .AsNoTracking()
                .AsQueryable();

            if (entities != null)
            {
                return entities;
            }
            else
            {
                return null;
            }

        }
    }
}

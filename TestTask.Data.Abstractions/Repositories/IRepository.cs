using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.DataBase.Entities;

namespace TestTask.Data.Abstractions.Repositories
{
    public interface IRepository<T> where T : class, IBaseEntity
    {
        IQueryable<T>? Get();
    }
}

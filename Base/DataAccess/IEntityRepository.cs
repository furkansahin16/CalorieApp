using Base.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.DataAccess
{
    public interface IEntityRepository<T,TContext> where T : class, IEntity, new() where TContext : DbContext
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        (List<T>,TContext) GetAll(Expression<Func<T, bool>> filter = null);
        (T,TContext) Get(Expression<Func<T, bool>> filter);
    }
}

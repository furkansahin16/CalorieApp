using Base.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Base.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity,TContext>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        
       
        public virtual void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }   
        }

        public virtual void Delete(TEntity entity)
        {
            using(var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }           
        }

        public virtual (TEntity,TContext) Get(Expression<Func<TEntity, bool>> filter)
        {
            TContext context = new();
            return (context.Set<TEntity>().SingleOrDefault(filter),context);
        }

        public virtual (List<TEntity>,TContext) GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            TContext context = new();
            return (filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(),context);
        }

        public virtual void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }             
        }
    }
}

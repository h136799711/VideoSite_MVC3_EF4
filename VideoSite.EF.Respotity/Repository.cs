using System;
using System.Collections.Generic;
using System.Linq;
using VideoSite.EF.Infrastructure;
using VideoSite.EF.DBContexts;
using System.Data.Entity;

namespace VideoSite.EF.Repository
{
    public abstract class Repository<T> : IRepository<T>, IUnitOfWork where T : class
    {
        public BaseContext Context { get; set; }

        public  DbSet<T> GetEntities()
        {
            return Context.Set<T>();    
        }

        public virtual void Add(T entity)
        {
            GetEntities().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            GetEntities().Remove(entity);

        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }


        public virtual void Modify(T entity)
        {
            Context.Entry<T>(entity).State = System.Data.EntityState.Modified;

        }

        public virtual IEnumerable<T> List()
        {
            return GetEntities().ToList<T>();
        }
    }
}

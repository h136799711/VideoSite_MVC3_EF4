using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace VideoSite.EF.Infrastructure
{
    public class Repository<T>:IRepository<T>,IUnitOfWork where T : class
    {
        public DbContext context;
        public Repository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("unitOfWork can not be null");
            }
            context = unitOfWork as DbContext;
        }


        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }


        public void Modify(T entity)
        {
            
            
        }

        public IEnumerable<T> List()
        {
            return context.Set<T>().ToList<T>();
        }
    }
}

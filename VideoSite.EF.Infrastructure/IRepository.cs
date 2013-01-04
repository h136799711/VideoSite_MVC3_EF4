using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoSite.EF.Infrastructure
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> List();
        void Add(T entity);
        void Delete(T entity);
        void Modify(T entity);
    }
}

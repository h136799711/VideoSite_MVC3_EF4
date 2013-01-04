using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Respotity
{
    interface IRepository<T> where T:class
    {
        IEnumerable<T> FindAll(Func<T, bool> exp);
        void Add(T entity);
        void Delete(T entity);
        void Save();
    }
}

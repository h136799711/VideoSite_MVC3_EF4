using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoSite.EF.Infrastructure;
using VideoSite.Services.IServices;
namespace VideoSite.Services.Services
{

    public abstract class DataBaseService<T> : IDataBaseService<T> where T : class
    {

        private IRepository<T> _repo;
        public IRepository<T> Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }
        public DataBaseService(IRepository<T> repo)
        {
            _repo = repo;
        }
        public IEnumerable<T> List()
        {           
            return _repo.List();
        }

        public void Add(T entity)
        {
            _repo.Add(entity);
        }

        public void Delete(T entity)
        {
            _repo.Delete(entity);
        }

        public void Modify(T entity)
        {
            _repo.Modify(entity);
        }
    }
}

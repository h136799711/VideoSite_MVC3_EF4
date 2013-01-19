using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VideoSite.EF.Infrastructure;
using VideoSite.EF.IRepository;
using VideoSite.EF.Model;
namespace VideoSite.EF.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }

        public IList<User> getUserWith()
        {
            throw new NotImplementedException();
        }
    }
}

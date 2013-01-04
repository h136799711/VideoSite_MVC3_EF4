using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VideoSite.EF.Model;
using VideoSite.EF.Infrastructure;
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

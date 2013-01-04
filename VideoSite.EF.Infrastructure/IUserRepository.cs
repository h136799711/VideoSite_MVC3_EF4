using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoSite.EF.Model;
namespace VideoSite.EF.Infrastructure
{
    public interface IUserRepository:IRepository<User>
    {
        IList<User> getUserWith();
    }
}

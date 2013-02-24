using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoSite.EF.Model;
namespace VideoSite.Services.IServices
{
    public interface IUserService : IDataBaseService<User>
    {
        User GetUserById(int id);
    }
}

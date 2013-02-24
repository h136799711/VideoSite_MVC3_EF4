using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoSite.EF.Model;
using VideoSite.Services.IServices;
using VideoSite.EF.IRepository;
using VideoSite.EF.Repository;

namespace VideoSite.Services.Services
{
    public class UserService : DataBaseService<User>,IUserService
    {

        public new IUserRepository Repo
        {
            get
            {
                return base.Repo as IUserRepository;
            }

        }
        public UserService(IUserRepository repo):base(repo)
        {
        }

        public User GetUserById(int id)
        {
            return (Repo).GetUserById(id);
        }
    }
}

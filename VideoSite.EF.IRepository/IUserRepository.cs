﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoSite.EF.Infrastructure;
using VideoSite.EF.Model;

namespace VideoSite.EF.IRepository
{
    public interface IUserRepository:IRepository<User>
    {
        User GetUserById(int id);
    }
}

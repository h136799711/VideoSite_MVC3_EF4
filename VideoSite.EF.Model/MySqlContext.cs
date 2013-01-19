using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using VideoSite.EF.Infrastructure;

namespace VideoSite.EF.Model
{
    public class MySqlContext : DbContext, IUnitOfWork
    {
        public MySqlContext()
            : base()
        {
            Database.SetInitializer<MySqlContext>(new DropCreateDatabaseIfModelChanges<MySqlContext>());
        }
        public DbSet<User> Users { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}

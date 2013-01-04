using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using VideoSite.EF.Model;
using VideoSite.EF.Infrastructure;
namespace VideoSite.EF.Repository
{
    public class MainContext:DbContext,IUnitOfWork
    {
        public MainContext():base()
        {
            Database.SetInitializer<MainContext>(new DropCreateDatabaseIfModelChanges<MainContext>());
        }
        public DbSet<User> Users { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using VideoSite.EF.Infrastructure;
namespace VideoSite.EF.Model
{
    public class MSSqlContext:DbContext,IUnitOfWork
    {
        public MSSqlContext()
            : base()
        {
            Database.SetInitializer<MSSqlContext>(new DropCreateDatabaseIfModelChanges<MSSqlContext>());
        }
        public DbSet<User> Users { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}

using System.Data.Entity;
using VideoSite.EF.Infrastructure;

namespace VideoSite.EF.Model
{
    public class BaseContext : DbContext, IUnitOfWork
    {

        public virtual void Save()
        {
            throw new System.NotImplementedException();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

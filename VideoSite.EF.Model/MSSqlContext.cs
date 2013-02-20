using System.Data.Entity;

namespace VideoSite.EF.Model
{
    public class MSSqlContext:BaseContext
    {
        public MSSqlContext()
            : base()
        {
            Database.SetInitializer<MSSqlContext>(new DropCreateDatabaseIfModelChanges<MSSqlContext>());
        }
        public DbSet<User> Users { get; set; }

        public new void Save()
        {
            this.SaveChanges();
        }
    }
}

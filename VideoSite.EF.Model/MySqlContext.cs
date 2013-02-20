using System.Data.Entity;


namespace VideoSite.EF.Model
{
    public class MySqlContext :BaseContext
    {
        public MySqlContext()
            : base()
        {
            Database.SetInitializer<MySqlContext>(new DropCreateDatabaseIfModelChanges<MySqlContext>());
        }
        public DbSet<User> Users { get; set; }

        public new void Save()
        {
            this.SaveChanges();
        }
    }
}

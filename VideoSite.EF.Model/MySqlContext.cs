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

        public override void Save()
        {
            this.SaveChanges();
        }
    }
}

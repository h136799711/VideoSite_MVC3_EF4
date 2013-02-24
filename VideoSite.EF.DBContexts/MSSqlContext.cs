/****************************************************
 * MSSQL 访问类 
 * 创建日期：2013-02-23 
 * 作者:何必都
 * 最近修改日期：2013-02-23 
 ****************************************************/

using System.Data.Entity;
using VideoSite.EF.Infrastructure;

namespace VideoSite.EF.DBContexts
{
    public class MSSqlContext : BaseContext
    {
        public MSSqlContext()
            : base()
        {
            Database.SetInitializer<MSSqlContext>(new DropCreateDatabaseIfModelChanges<MSSqlContext>());
        }

        public override void Save()
        {
            this.SaveChanges();
        }
    }
}

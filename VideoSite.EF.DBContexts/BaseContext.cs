using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using VideoSite.EF.Infrastructure;
using VideoSite.EF.Model;

namespace VideoSite.EF.DBContexts
{
    public class BaseContext : DbContext, IUnitOfWork
    {
        public DbSet<User> Users { get { return Set<User>(); } }
        public DbSet<Tag> Tags { get { return Set<Tag>(); } }
        public DbSet<Record> Records { get { return Set<Record>(); } }
        public DbSet<Comment> Comments { get { return Set<Comment>(); } }

        public virtual void Save()
        {
            this.SaveChanges();
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User表字段，验证规则
            modelBuilder.Entity<User>().ToTable("tbUser");
            modelBuilder.Entity<User>().HasKey(T => T.UserId);
            modelBuilder.Entity<User>().Property(T => T.UserId)
                         .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<User>().Property(T => T.Username).IsRequired();
            modelBuilder.Entity<User>().Property(T => T.Username).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(T => T.Password).IsRequired();
            modelBuilder.Entity<Record>()
                 .HasRequired(T => T.RecordUser)
             .WithMany(T => T.Records)
             .HasForeignKey(T => T.UserId);


            base.OnModelCreating(modelBuilder);
        }
    }
}

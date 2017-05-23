using Business.Entities;
using Data.Core.Configurations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Core
{
    public class DIContext : DbContext
    {
        public DIContext()
           :base("DIContext")
        {
            Database.SetInitializer<DIContext>(null);
        }

        public DbSet<Article> ArticleSet { get; set; }
        public DbSet<Blog> BlogSet { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ArticleConfiguration());
            modelBuilder.Configurations.Add(new BlogConfiguration());
        }
    }
}

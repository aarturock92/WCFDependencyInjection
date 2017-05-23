using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Core.Configurations
{
    public class BlogConfiguration:EntityTypeConfiguration<Blog>
    {
        public BlogConfiguration()
        {
            HasKey(b => b.ID);
            Property(b => b.Name).IsRequired().HasMaxLength(100);
            Property(b => b.URL).IsRequired().HasMaxLength(200);
            Property(b => b.Owner).IsRequired().HasMaxLength(100);
            Ignore(b => b.ExtensionData);
        }
    }
}

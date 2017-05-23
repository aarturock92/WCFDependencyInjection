using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Core.Configurations
{
    public class ArticleConfiguration: EntityTypeConfiguration<Article>
    {
        public ArticleConfiguration()
        {
            HasKey(a => a.ID);
            Property(a => a.Title).IsRequired().HasMaxLength(100);
            Property(a => a.Contents).IsRequired();
            Property(a => a.Author).IsRequired().HasMaxLength(100);
            Property(a => a.URL).IsRequired().HasMaxLength(200);
            Ignore(a => a.ExtensionData);
            Ignore(a => a.ContentLength);
        }
    }
}

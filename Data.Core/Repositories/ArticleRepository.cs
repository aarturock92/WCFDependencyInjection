﻿using Business.Entities;
using Data.Core.Infrastructure;
using System.Linq;

namespace Data.Core.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Article GetArticleByTitle(string articleTitle)
        {
            var _article = this.DbContext.ArticleSet.Where(b => b.Title == articleTitle).FirstOrDefault();

            return _article;
        }
    }

    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleByTitle(string articleTitle);
    }
}

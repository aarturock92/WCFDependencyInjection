using System;
using System.Data.Entity;

namespace Data.Core.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DIContext dbContext;

        public DIContext Init()
        {
            return dbContext ?? (dbContext = new DIContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        
    }
}

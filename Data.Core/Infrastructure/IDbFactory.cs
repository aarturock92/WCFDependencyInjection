using System;
using System.Data.Entity;

namespace Data.Core.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        DIContext Init();
    }
}

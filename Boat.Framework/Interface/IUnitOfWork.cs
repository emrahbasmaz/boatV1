using System;
using System.Collections.Generic;
using System.Text;

namespace Boat.Framework.Interface
{
    public interface IUnitOfWork  :  IDisposable
    {
        IRepository<TEntity, long> repository<TEntity>() where TEntity : class;

        void Commit();
    }
}

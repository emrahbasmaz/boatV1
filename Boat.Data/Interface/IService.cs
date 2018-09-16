using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Data.Interface
{
    /// <summary>
    /// All Service interface must implement this interface in order to Castle Windsor inject constructors
    /// </summary>
    public interface IService
    {

    }

    /// <summary>
    /// All Service interface must implement this interface in order to Castle Windsor inject constructors
    /// </summary>
    public interface IService<TEntity, TPrimaryKey, TRepository> : IService
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TPrimaryKey id);
        Task<TEntity> GetAsync(TPrimaryKey id);
        object Add(TEntity entity);
        Task<int> AddAsync(TEntity entity);
        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}

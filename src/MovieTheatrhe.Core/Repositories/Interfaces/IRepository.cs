using MovieTheatrhe.Core.Models.Interfaces;
using System.Linq.Expressions;

namespace MovieTheatrhe.Core.Repositories.Interfaces
{
    internal interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(int id);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
    }
}

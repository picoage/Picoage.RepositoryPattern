using System.Linq.Expressions;

namespace Picoage.Repository.DocumentDb
{
    public interface IDataStore<TEntity> where TEntity : IIdompotent
    {
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task UpsertAsync(TEntity entity);
        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);
    }
}

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Config.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetListAsync();

        DbSet<TEntity> GetDbSet();

        Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> predicate);

        Task CreateAsync(TEntity entity);

        Task EditAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

    }
}

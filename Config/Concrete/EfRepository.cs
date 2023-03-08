using Config.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Config.Concrete
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        public EfRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public DbSet<TEntity> GetDbSet()
        {
            return _context.Set<TEntity>();
        }

        public Task<List<TEntity>> GetListAsync()
        {
            return _context.Set<TEntity>().ToListAsync();
        }
    }
}

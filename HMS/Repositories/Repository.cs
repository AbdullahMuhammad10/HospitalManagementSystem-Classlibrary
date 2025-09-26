
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(int id) => await dbSet.FindAsync(id);

        public async Task<IEnumerable<T>> GetAllAsync() => await dbSet.ToListAsync();

        public async Task AddAsync(T entity) => await dbSet.AddAsync(entity);

        public Task UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            return Task.CompletedTask;
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }
        public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();
    }
}



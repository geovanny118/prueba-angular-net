using Microsoft.EntityFrameworkCore;
using Server.Data.Context;
using Server.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ServerContext db;

        public BaseRepository(ServerContext context) =>
            db = context;

        public virtual async Task Add(T obj)
        {
            db.Add(obj);
            await db.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAll() =>
            await db.Set<T>().ToListAsync();

        public virtual async Task<T> GetById(int? id) =>
            await db.Set<T>().FindAsync(id);

        public virtual async Task Remove(T obj)
        {
            db.Set<T>().Remove(obj);
            await db.SaveChangesAsync();
        }

        public virtual async Task Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public void Dispose() =>
            db.Dispose();
    }
}

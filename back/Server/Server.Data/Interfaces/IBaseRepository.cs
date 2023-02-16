using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Interfaces
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {

        public Task<IEnumerable<T>> Get(bool excludeRelationships = true);

        public Task<T> Get(int id);

        public Task<T> Create(T entity);

        public Task<IEnumerable<T>> Create(IEnumerable<T> entity);

        public Task<T> Update(T entity);

        public Task<T> Delete(int id);
    }
}

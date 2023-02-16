using Server.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Data.Context;
using Server.Data.Interfaces;


namespace Server.Services
{
    public interface IBaseService<T> where T : IBaseEntity
    {

        Task<IEnumerable<T>> Get(bool excludeRelationships = true);

        Task<T> Get(int id);

        Task<T> Create(T entity);

        Task<IEnumerable<T>> Create(IEnumerable<T> entity);

        Task<T> Update(T entity);

        Task<T> Delete(int id);
    }
}

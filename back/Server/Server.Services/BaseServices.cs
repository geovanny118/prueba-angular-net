using Server.Data;
using Server.Data.Interfaces;
using Server.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : IBaseEntity
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        public Task<T> Create(T entity) => _repository.Create(entity);

        public Task<IEnumerable<T>> Create(IEnumerable<T> entity) => _repository.Create(entity);

        public Task<T> Delete(int id) => _repository.Delete(id);

        public Task<IEnumerable<T>> Get(bool excludeRelationships = true) => _repository.Get(excludeRelationships);

        public Task<T> Get(int id) => _repository.Get(id);

        public Task<T> Update(T entity) => _repository.Update(entity);

    }
}

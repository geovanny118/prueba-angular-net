using System;
using Server.Data.Interfaces;
using Server.Data.Models;
using Server.Services;

namespace Server.Services
{
    public class RolService : BaseService<Rol>, IRolService
    {
        private readonly IRolRepository _repository;

        public RolService(IRolRepository repository) : base(repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }


}

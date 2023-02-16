using Server.Data.Context;
using Server.Data.Interfaces;
using Server.Data.Models;
using System;

namespace Server.Data.Repositories
{
    public class RolRepository : BaseRepository<Rol>, IRolRepository
    {
        private readonly ServerContext _context;

        public RolRepository(ServerContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}

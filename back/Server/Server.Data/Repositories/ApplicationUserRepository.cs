using Server.Data.Context;
using Server.Data.Interfaces;
using Server.Data.Models;
using System;

namespace Server.Data.Repositories
{
    public class ApplicationUserRepository : BaseRepository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ServerContext _context;

        public ApplicationUserRepository(ServerContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}

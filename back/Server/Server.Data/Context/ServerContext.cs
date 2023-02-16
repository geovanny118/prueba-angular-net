using Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Server.Data.Context
{
    public class ServerContext : IdentityDbContext
    {
        public ServerContext(DbContextOptions<ServerContext> options)
             : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Creación de roles
            var adminRole = new IdentityRole() { Id = "1", Name = "Administrador", NormalizedName = "ADMINISTRADOR" };
            var userRole = new IdentityRole() { Id = "2", Name = "Usuario", NormalizedName = "USUARIO" };
            builder.Entity<IdentityRole>().HasData(new IdentityRole[] { adminRole, userRole });

            //Creacion de usuario administrador
            var passHash = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser()
            {
                Id = "sp6klw07n-t3m0-3uz0-ilkz-65rcoigmmv77",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                PasswordHash = passHash.HashPassword(null, "mY1R@^KJUxR$M2AL")
            };

            var adminUserDetails = new UserDetails()
            {
                Id = 1,
                UserId = adminUser.Id,
                Name = "Admin",
                LastName = "Arkana",
                IsActive = true,
            };

            builder.Entity<IdentityUser>().HasData(new IdentityUser[] { adminUser });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = adminUser.Id, RoleId = "1" });
            builder.Entity<UserDetails>().HasData(new UserDetails[] { adminUserDetails });

            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("Users", "dbo");
            builder.Entity<IdentityRole>().ToTable("Roles", "dbo");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "dbo");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "dbo");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "dbo");
        }

        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<UserRefreshToken> UserToken { get; set; }

        public DbSet<Rol> RolesApplicationUsers { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Authentication.ApplicationCore.Entity;
namespace Authentication.Infrastructure.Data
{
	public class AutheticationDbContext:DbContext
	{
		public AutheticationDbContext(DbContextOptions<AutheticationDbContext> options):base(options)
		{
		}


		public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}


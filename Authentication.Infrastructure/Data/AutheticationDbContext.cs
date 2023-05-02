using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Authentication.ApplicationCore.Entity;
namespace Authentication.Infrastructure.Data
{
	public class AutheticationDbContext:IdentityDbContext<ApplicationUser>
	{
		public AutheticationDbContext(DbContextOptions<AutheticationDbContext> options):base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}


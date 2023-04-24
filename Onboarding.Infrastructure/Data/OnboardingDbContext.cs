using System;
using Onboarding.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Onboarding.Infrastructure.Data
{
	public class OnboardingDbContext: DbContext
	{
		public OnboardingDbContext(DbContextOptions<OnboardingDbContext> options):base(options)
		{
		}


		public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategories { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
    }
}


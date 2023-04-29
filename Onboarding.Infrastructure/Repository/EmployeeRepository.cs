using System;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.ApplicationCore.Entity;
using Onboarding.Infrastructure.Data;
namespace Onboarding.Infrastructure.Repository
{
	public class EmployeeRepository:BaseRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(OnboardingDbContext context) : base(context)
        {
		}
	}
}


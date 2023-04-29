using System;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.ApplicationCore.Entity;
using Onboarding.Infrastructure.Data;
namespace Onboarding.Infrastructure.Repository
{
	public class EmployeeRoleRepository:BaseRepository<EmployeeRole>, IEmployeeRoleRepository
	{
		public EmployeeRoleRepository(OnboardingDbContext context) : base(context)
        {
		}
	}
}


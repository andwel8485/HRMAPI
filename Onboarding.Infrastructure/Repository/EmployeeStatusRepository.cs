using System;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.ApplicationCore.Entity;
using Onboarding.Infrastructure.Data;

namespace Onboarding.Infrastructure.Repository
{
	public class EmployeeStatusRepository:BaseRepository<EmployeeStatus>, IEmployeeStatusRepository
	{
		public EmployeeStatusRepository(OnboardingDbContext context) : base(context)
        {
		}
	}
}


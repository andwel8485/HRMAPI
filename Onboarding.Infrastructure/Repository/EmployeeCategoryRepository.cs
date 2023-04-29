using System;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.ApplicationCore.Entity;
using Onboarding.Infrastructure.Data;

namespace Onboarding.Infrastructure.Repository
{
	public class EmployeeCategoryRepository:BaseRepository<EmployeeCategory>, IEmployeeCategoryRepository
	{
		public EmployeeCategoryRepository(OnboardingDbContext context):base(context)
		{
		}
	}
}


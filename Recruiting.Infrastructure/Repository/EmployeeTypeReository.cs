using System;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Repository
{
	public class EmployeeTypeReository: BaseRepository<EmployeeType>, IEmployeeTypeRepository
	{
		public EmployeeTypeReository(RecruitingDbContext context) : base(context)
        {
		}
	}
}


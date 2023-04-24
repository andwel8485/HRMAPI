using System;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Repository
{
	public class JobCategoryRepository: BaseRepository<JobCategory>, IJobCategoryRepository
	{
		public JobCategoryRepository(RecruitingDbContext context) : base(context)
        {
		}
	}
}


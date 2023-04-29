using System;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Repository
{
	public class JobRequirementRepository:BaseRepository<JobRequirement>, IJobRequirementRepository
	{
		public JobRequirementRepository(RecruitingDbContext context) : base(context)
        {
		}
	}
}


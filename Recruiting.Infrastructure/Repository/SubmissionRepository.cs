using System;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Repository
{
	public class SubmissionRepository:BaseRepository<Submission>, ISubmissionRepository
	{
		public SubmissionRepository(RecruitingDbContext context) : base(context)
        {
		}
	}
}


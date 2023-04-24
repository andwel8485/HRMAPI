using System;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Repository
{
	public class CandidateRepository:BaseRepository<Candidate>, ICandidateRepository
	{
		public CandidateRepository(RecruitingDbContext context):base(context)
		{
		}
	}
}


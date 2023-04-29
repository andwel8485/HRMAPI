using System;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Repository
{
	public class StatusRepository:BaseRepository<Status>, IStatusRepository
	{
		public StatusRepository(RecruitingDbContext context) : base(context)
        {
		}
	}
}


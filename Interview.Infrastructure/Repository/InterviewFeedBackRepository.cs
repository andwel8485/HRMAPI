using System;
using System.Data;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Entity;
using Interview.Infrastructure.Data;
using Interview.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace Interview.Infrastructure.Repository
{
	public class InterviewFeedBackRepository:BaseRepository<InterviewFeedBack>, IInterviewFeedBackRepository
	{
        public InterviewFeedBackRepository(InterviewDbConnection interviewDbConnection) : base(interviewDbConnection)
        {
            base._tableName = "InterviewFeedBacks";
        }

        public override async Task<int> InsertAsync(InterviewFeedBack entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Insert Into {base._tableName} Values(@Rating, @Comment)", entity);
            }
        }

        public override async Task<int> UpdateAsync(InterviewFeedBack entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Update {base._tableName} " +
                    $"Set Rating = @Rating, Comment = @Comment Where Id=@Id", entity);
            }
        }
    }
}


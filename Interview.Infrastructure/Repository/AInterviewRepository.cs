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
	public class AInterviewRepository:BaseRepository<AInterview>, IAInterviewRepository
	{
        public AInterviewRepository(InterviewDbConnection interviewDbConnection) : base(interviewDbConnection)
        {
            base._tableName = "AInterviews";
        }

        public override async Task<int> InsertAsync(AInterview entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Insert Into {base._tableName} " +
                    $"Values(@RecrutierId, @SubmissionId, @InterviewTypeId, " +
                           $"@InterviewRound, @ScheduledOn, @InterviewerId, @FeedBackId)", entity);
            }
        }

        public override async Task<int> UpdateAsync(AInterview entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Update {base._tableName} " +
                    $"Set RecrutierId = @RecrutierId, " +
                    $"SubmissionId = @SubmissionId, " +
                    $"InterviewTypeId = @InterviewTypeId, " +
                    $"InterviewRound=@InterviewRound, " +
                    $"ScheduledOn=@ScheduledOn, " +
                    $"InterviewerId=@InterviewerId Where Id=@Id", entity);
            }
        }
    }
}


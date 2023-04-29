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
	public class InterviewerRepository:BaseRepository<Interviewer>, IInterviewerRepository
	{
        public InterviewerRepository(InterviewDbConnection interviewDbConnection) : base(interviewDbConnection)
        {
            base._tableName = "Interviewers";
        }

        public override async Task<int> InsertAsync(Interviewer entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Insert Into {base._tableName} Values(@FirstName, @LastName, @EmployeeId)", entity);
            }
        }

        public override async Task<int> UpdateAsync(Interviewer entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Update {base._tableName} " +
                    $"Set FirstName = @FirstName, LastName = @LastName, EmployeeId = @EmployeeId Where Id=@Id", entity);
            }
        }
    }
}


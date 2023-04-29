﻿using System;
using System.Data;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Entity;
using Interview.Infrastructure.Data;
using Interview.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace Interview.Infrastructure.Repository
{
	public class InterviewTypeRepository:BaseRepository<InterviewType>, IInterviewTypeRepository
	{
        public InterviewTypeRepository(InterviewDbConnection interviewDbConnection) : base(interviewDbConnection)
        {
            base._tableName = "InterviewTypes";
        }

        public override async Task<int> InsertAsync(InterviewType entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Insert Into {base._tableName} Values(@Description)", entity);
            }
        }

        public override async Task<int> UpdateAsync(InterviewType entity)
        {
            using (IDbConnection conn = base._connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Update {base._tableName} " +
                    $"Set Description = @Description Where Id=@Id", entity);
            }
        }
    }
}


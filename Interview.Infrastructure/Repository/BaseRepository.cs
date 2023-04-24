using System;
using Interview.Infrastructure.Data;
using Interview.ApplicationCore.Contract.Repository;
using System.Data;
using Dapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Interview.Infrastructure.Repository
{
	public abstract class BaseRepository<T>:IBaseRepository<T> where T:class
	{

        protected readonly InterviewDbConnection _connection;
        protected string _tableName;
		public BaseRepository(InterviewDbConnection interviewDbConnection)
		{
            _connection = interviewDbConnection;
		}

        public async Task<int> DeleteAsync(int id)
        {

            using (IDbConnection conn = _connection.GetConnection())
            {
                return await conn.ExecuteAsync($"Delete From {_tableName} Where Id=@Id", new { Id = id });
            }
                
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (IDbConnection conn = _connection.GetConnection())
            {
                return await conn.QueryAsync<T>($"Select * From {_tableName}");
            }
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            using (IDbConnection conn = _connection.GetConnection())
            {
                return await conn.QuerySingleOrDefaultAsync<T>($"SELECT * FROM {_tableName} WHERE Id=@Id", new { Id = id });
            }
        }

        public abstract Task<int> InsertAsync(T entity);


        public abstract Task<int> UpdateAsync(T entity);
        
    }
}


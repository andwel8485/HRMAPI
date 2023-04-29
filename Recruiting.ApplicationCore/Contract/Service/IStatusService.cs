using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface IStatusService
	{
        public Task<IEnumerable<Status>> GetAllDataAsync();
        public Task<Status> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Status entity);
        public Task<int> DeleteDataAsync(Status entity);
        public Task<int> InsertDataAsync(Status entity);
    }
}


using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface IJobCategoryService
	{
        public Task<IEnumerable<JobCategory>> GetAllDataAsync();
        public Task<JobCategory> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(JobCategory entity);
        public Task<int> DeleteDataAsync(JobCategory entity);
        public Task<int> InsertDataAsync(JobCategory entity);
    }
}


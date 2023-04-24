using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface IJobCategoryService
	{
        public Task<IEnumerable<JobCategory>> GetAllDataAsync();
        public Task<JobCategory> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(JobCategory j);
        public Task<int> DeleteDataAsync(JobCategory j);
        public Task<int> InsertDataAsync(JobCategory j);
    }
}


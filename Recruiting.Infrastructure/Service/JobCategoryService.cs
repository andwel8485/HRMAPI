using System;
using Recruiting.ApplicationCore.Entity;
using Recruiting.ApplicationCore.Contract.Service;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.Infrastructure.Repository;

namespace Recruiting.Infrastructure.Service
{
	public class JobCategoryService:IJobCategoryService
	{
        private readonly IJobCategoryRepository _repo;
		public JobCategoryService(IJobCategoryRepository jobCategoryRepository)
		{
            _repo = jobCategoryRepository;
		}

        public Task<int> DeleteDataAsync(JobCategory data)
        {
            return _repo.DeleteAsync(data);
        }

        public Task<IEnumerable<JobCategory>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<JobCategory> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(JobCategory data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(JobCategory data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


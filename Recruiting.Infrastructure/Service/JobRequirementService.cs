using System;
using Recruiting.ApplicationCore.Entity;
using Recruiting.ApplicationCore.Contract.Service;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.Infrastructure.Repository;

namespace Recruiting.Infrastructure.Service
{
	public class JobRequirementService:IJobRequirementService
	{
        private readonly IJobRequirementRepository _repo;
        public JobRequirementService(IJobRequirementRepository jobRequirementRepository)
        {
            _repo = jobRequirementRepository;
        }
        public Task<int> DeleteDataAsync(JobRequirement data)
        {
            return _repo.DeleteAsync(data);
        }

        public Task<IEnumerable<JobRequirement>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<JobRequirement> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(JobRequirement data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(JobRequirement data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


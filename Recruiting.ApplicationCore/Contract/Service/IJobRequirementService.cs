using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface IJobRequirementService
	{
        public Task<IEnumerable<JobRequirement>> GetAllDataAsync();
        public Task<JobRequirement> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(JobRequirement entity);
        public Task<int> DeleteDataAsync(JobRequirement entity);
        public Task<int> InsertDataAsync(JobRequirement entity);
    }
}


using System;
using Interview.ApplicationCore.Entity;

namespace Interview.ApplicationCore.Contract.Service
{
	public interface IAInterviewService
	{
        public Task<IEnumerable<AInterview>> GetAllDataAsync();
        public Task<AInterview> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(AInterview entity);
        public Task<int> DeleteDataAsync(int id);
        public Task<int> InsertDataAsync(AInterview entity);
    }
}


using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface ISubmissionService
	{
        public Task<IEnumerable<Submission>> GetAllDataAsync();
        public Task<Submission> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Submission entity);
        public Task<int> DeleteDataAsync(Submission entity);
        public Task<int> InsertDataAsync(Submission entity);
    }
}


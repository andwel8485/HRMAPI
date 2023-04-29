using System;
using Recruiting.ApplicationCore.Entity;
using Recruiting.ApplicationCore.Contract.Service;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.Infrastructure.Repository;

namespace Recruiting.Infrastructure.Service
{
	public class SubmissionService:ISubmissionService
	{
        private readonly ISubmissionRepository _repo;
        public SubmissionService(ISubmissionRepository submissionRepository)
        {
            _repo = submissionRepository;
        }
        public Task<int> DeleteDataAsync(Submission data)
        {
            return _repo.DeleteAsync(data);
        }

        public Task<IEnumerable<Submission>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Submission> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Submission data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(Submission data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


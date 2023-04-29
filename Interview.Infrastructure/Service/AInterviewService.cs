using System;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Entity;

namespace Interview.Infrastructure.Service
{
	public class AInterviewService:IAInterviewService
	{
        private readonly IAInterviewRepository _repo;
        public AInterviewService(IAInterviewRepository aInterviewRepository)
        {
            _repo = aInterviewRepository;
        }

        public Task<int> DeleteDataAsync(int id)
        {
            return _repo.DeleteAsync(id);
        }

        public Task<IEnumerable<AInterview>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<AInterview> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(AInterview data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(AInterview data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


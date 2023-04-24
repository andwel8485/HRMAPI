using System;
using Recruiting.ApplicationCore.Contract.Service;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.Infrastructure.Repository;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.Infrastructure.Service
{
	public class CandidateService:ICandidateService
	{
        private readonly ICandidateRepository _repo;
		public CandidateService(ICandidateRepository candidateRepository)
		{
            _repo = candidateRepository;

        }

        public Task<int> DeleteDataAsync(Candidate data)
        {
            return _repo.DeleteAsync(data);
        }

        public Task<IEnumerable<Candidate>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Candidate> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Candidate data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(Candidate data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


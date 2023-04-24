using System;
using Recruiting.ApplicationCore.Entity;
namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface ICandidateService
	{
		public Task<IEnumerable<Candidate>> GetAllDataAsync();
        public Task<Candidate> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Candidate c);
        public Task<int> DeleteDataAsync(Candidate c);
        public Task<int> InsertDataAsync(Candidate c);
    }
}


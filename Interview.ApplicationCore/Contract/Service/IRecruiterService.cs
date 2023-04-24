using System;
using Interview.ApplicationCore.Entity;

namespace Interview.ApplicationCore.Contract.Service
{
	public interface IRecruiterService
	{
        public Task<IEnumerable<Recruiter>> GetAllDataAsync();
        public Task<Recruiter> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Recruiter r);
        public Task<int> DeleteDataAsync(int id);
        public Task<int> InsertDataAsync(Recruiter r);
    }

}


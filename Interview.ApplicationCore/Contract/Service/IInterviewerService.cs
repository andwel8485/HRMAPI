using System;
using Interview.ApplicationCore.Entity;

namespace Interview.ApplicationCore.Contract.Service
{
	public interface IInterviewerService
	{
        public Task<IEnumerable<Interviewer>> GetAllDataAsync();
        public Task<Interviewer> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Interviewer entity);
        public Task<int> DeleteDataAsync(int id);
        public Task<int> InsertDataAsync(Interviewer entity);
    }
}


using System;
using Interview.ApplicationCore.Entity;

namespace Interview.ApplicationCore.Contract.Service
{
	public interface IInterviewFeedBackService
	{
        public Task<IEnumerable<InterviewFeedBack>> GetAllDataAsync();
        public Task<InterviewFeedBack> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(InterviewFeedBack entity);
        public Task<int> DeleteDataAsync(int id);
        public Task<int> InsertDataAsync(InterviewFeedBack entity);
    }
}


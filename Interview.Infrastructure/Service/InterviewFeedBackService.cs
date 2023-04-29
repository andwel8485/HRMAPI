using System;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Entity;

namespace Interview.Infrastructure.Service
{
	public class InterviewFeedBackService:IInterviewFeedBackService
	{
        private readonly IInterviewFeedBackRepository _repo;
        public InterviewFeedBackService(IInterviewFeedBackRepository interviewFeedBackRepository)
        {
            _repo = interviewFeedBackRepository;
        }

        public Task<int> DeleteDataAsync(int id)
        {
            return _repo.DeleteAsync(id);
        }

        public Task<IEnumerable<InterviewFeedBack>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<InterviewFeedBack> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(InterviewFeedBack data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(InterviewFeedBack data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


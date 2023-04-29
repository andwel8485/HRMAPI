using System;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Entity;

namespace Interview.Infrastructure.Service
{
	public class InterviewerService:IInterviewerService
	{
        private readonly IInterviewerRepository _repo;
        public InterviewerService(IInterviewerRepository interviewerRepository)
        {
            _repo = interviewerRepository;
        }

        public Task<int> DeleteDataAsync(int id)
        {
            return _repo.DeleteAsync(id);
        }

        public Task<IEnumerable<Interviewer>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Interviewer> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Interviewer data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(Interviewer data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


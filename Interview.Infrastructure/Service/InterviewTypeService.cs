using System;
using Interview.ApplicationCore.Contract.Repository;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Entity;

namespace Interview.Infrastructure.Service
{
	public class InterviewTypeService:IInterviewTypeService
	{
        private readonly IInterviewTypeRepository _repo;
        public InterviewTypeService(IInterviewTypeRepository interviewTypeRepository)
        {
            _repo = interviewTypeRepository;
        }

        public Task<int> DeleteDataAsync(int id)
        {
            return _repo.DeleteAsync(id);
        }

        public Task<IEnumerable<InterviewType>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<InterviewType> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(InterviewType data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(InterviewType data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


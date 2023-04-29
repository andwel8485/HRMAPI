using System;
using Interview.ApplicationCore.Entity;

namespace Interview.ApplicationCore.Contract.Service
{
	public interface IInterviewTypeService
	{
        public Task<IEnumerable<InterviewType>> GetAllDataAsync();
        public Task<InterviewType> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(InterviewType entity);
        public Task<int> DeleteDataAsync(int id);
        public Task<int> InsertDataAsync(InterviewType entity);
    }
}


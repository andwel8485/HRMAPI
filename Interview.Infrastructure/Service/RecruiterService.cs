using System;
using Interview.ApplicationCore.Entity;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Contract.Repository;


namespace Interview.Infrastructure.Service
{
	public class RecruiterService:IRecruiterService
	{

        private readonly IRecruiterRepository _repo;
		public RecruiterService(IRecruiterRepository recruiterRepository)
		{
            _repo = recruiterRepository;
		}

        public Task<int> DeleteDataAsync(int id)
        {
            return _repo.DeleteAsync(id);
        }

        public Task<IEnumerable<Recruiter>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Recruiter> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Recruiter data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(Recruiter data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


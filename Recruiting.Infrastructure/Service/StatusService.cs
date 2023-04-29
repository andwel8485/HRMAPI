using System;
using Recruiting.ApplicationCore.Entity;
using Recruiting.ApplicationCore.Contract.Service;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.Infrastructure.Repository;

namespace Recruiting.Infrastructure.Service
{
	public class StatusService:IStatusService
	{
        private readonly IStatusRepository _repo;
        public StatusService(IStatusRepository statusRepository)
        {
            _repo = statusRepository;
        }
        public Task<int> DeleteDataAsync(Status data)
        {
            return _repo.DeleteAsync(data);
        }

        public Task<IEnumerable<Status>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Status> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Status data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(Status data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


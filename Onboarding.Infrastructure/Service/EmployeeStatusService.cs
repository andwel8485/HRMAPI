using System;
using Onboarding.ApplicationCore.Contract.Service;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.Infrastructure.Repository;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.Infrastructure.Service
{
	public class EmployeeStatusService:IEmployeeStatusService
	{
        private readonly IEmployeeStatusRepository _repo;
        public EmployeeStatusService(IEmployeeStatusRepository employeeStatusRepository)
        {
            _repo = employeeStatusRepository;
        }

        public Task<int> DeleteDataAsync(EmployeeStatus e)
        {
            return _repo.DeleteAsync(e);
        }

        public Task<IEnumerable<EmployeeStatus>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<EmployeeStatus> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(EmployeeStatus e)
        {
            return _repo.InsertAsync(e);
        }

        public Task<int> UpdateDataAsync(EmployeeStatus e)
        {
            return _repo.UpdateAsync(e);
        }
    }
}


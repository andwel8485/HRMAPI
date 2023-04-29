using System;
using Onboarding.ApplicationCore.Contract.Service;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.Infrastructure.Repository;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.Infrastructure.Service
{
	public class EmployeeRoleService:IEmployeeRoleService
	{
        private readonly IEmployeeRoleRepository _repo;
        public EmployeeRoleService(IEmployeeRoleRepository employeeRoleRepository)
        {
            _repo = employeeRoleRepository;
        }

        public Task<int> DeleteDataAsync(EmployeeRole e)
        {
            return _repo.DeleteAsync(e);
        }

        public Task<IEnumerable<EmployeeRole>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<EmployeeRole> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(EmployeeRole e)
        {
            return _repo.InsertAsync(e);
        }

        public Task<int> UpdateDataAsync(EmployeeRole e)
        {
            return _repo.UpdateAsync(e);
        }
    }
}


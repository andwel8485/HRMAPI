using System;
using Onboarding.ApplicationCore.Contract.Service;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.Infrastructure.Repository;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.Infrastructure.Service
{
	public class EmployeeService:IEmployeeService
	{
        private readonly IEmployeeRepository _repo;
		public EmployeeService(IEmployeeRepository employeeRepository)
		{
            _repo = employeeRepository;
		}

        public Task<int> DeleteDataAsync(Employee e)
        {
            return _repo.DeleteAsync(e);
        }

        public Task<IEnumerable<Employee>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Employee> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Employee e)
        {
            return _repo.InsertAsync(e);
        }

        public Task<int> UpdateDataAsync(Employee e)
        {
            return _repo.UpdateAsync(e);
        }
    }
}


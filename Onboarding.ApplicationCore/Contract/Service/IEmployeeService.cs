using System;
using Onboarding.ApplicationCore.Entity;
namespace Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeService
	{
        public Task<IEnumerable<Employee>> GetAllDataAsync();
        public Task<Employee> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Employee e);
        public Task<int> DeleteDataAsync(Employee e);
        public Task<int> InsertDataAsync(Employee e);
    }
}


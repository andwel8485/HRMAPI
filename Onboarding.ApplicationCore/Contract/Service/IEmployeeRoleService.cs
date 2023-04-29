using System;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeRoleService
	{
        public Task<IEnumerable<EmployeeRole>> GetAllDataAsync();
        public Task<EmployeeRole> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(EmployeeRole e);
        public Task<int> DeleteDataAsync(EmployeeRole e);
        public Task<int> InsertDataAsync(EmployeeRole e);
    }
}


using System;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeCategoryService
	{
        public Task<IEnumerable<EmployeeCategory>> GetAllDataAsync();
        public Task<EmployeeCategory> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(EmployeeCategory e);
        public Task<int> DeleteDataAsync(EmployeeCategory e);
        public Task<int> InsertDataAsync(EmployeeCategory e);
    }
}


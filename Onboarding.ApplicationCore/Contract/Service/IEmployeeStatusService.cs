using System;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.ApplicationCore.Contract.Service
{
	public interface IEmployeeStatusService
	{
        public Task<IEnumerable<EmployeeStatus>> GetAllDataAsync();
        public Task<EmployeeStatus> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(EmployeeStatus e);
        public Task<int> DeleteDataAsync(EmployeeStatus e);
        public Task<int> InsertDataAsync(EmployeeStatus e);
    }
}


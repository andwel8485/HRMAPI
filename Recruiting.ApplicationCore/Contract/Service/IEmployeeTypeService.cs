using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface IEmployeeTypeService
	{
        public Task<IEnumerable<EmployeeType>> GetAllDataAsync();
        public Task<EmployeeType> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(EmployeeType c);
        public Task<int> DeleteDataAsync(EmployeeType c);
        public Task<int> InsertDataAsync(EmployeeType c);
    }
}


using System;
using Recruiting.ApplicationCore.Entity;

namespace Recruiting.ApplicationCore.Contract.Service
{
	public interface IEmployeeTypeService
	{
        public Task<IEnumerable<EmployeeType>> GetAllDataAsync();
        public Task<EmployeeType> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(EmployeeType entity);
        public Task<int> DeleteDataAsync(EmployeeType entity);
        public Task<int> InsertDataAsync(EmployeeType entity);
    }
}


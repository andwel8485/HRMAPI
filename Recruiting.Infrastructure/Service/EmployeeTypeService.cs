using System;
using Recruiting.ApplicationCore.Entity;
using Recruiting.ApplicationCore.Contract.Service;
using Recruiting.ApplicationCore.Contract.Repository;
using Recruiting.Infrastructure.Repository;

namespace Recruiting.Infrastructure.Service
{
	public class EmployeeTypeService:IEmployeeTypeService
	{
        private readonly IEmployeeTypeRepository _repo;
		public EmployeeTypeService(IEmployeeTypeRepository employeeTypeRepository)
		{
            _repo = employeeTypeRepository;
		}
        public Task<int> DeleteDataAsync(EmployeeType data)
        {
            return _repo.DeleteAsync(data);
        }

        public Task<IEnumerable<EmployeeType>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<EmployeeType> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(EmployeeType data)
        {
            return _repo.InsertAsync(data);
        }

        public Task<int> UpdateDataAsync(EmployeeType data)
        {
            return _repo.UpdateAsync(data);
        }
    }
}


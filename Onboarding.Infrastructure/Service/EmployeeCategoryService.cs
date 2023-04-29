using System;
using Onboarding.ApplicationCore.Contract.Service;
using Onboarding.ApplicationCore.Contract.Repository;
using Onboarding.Infrastructure.Repository;
using Onboarding.ApplicationCore.Entity;

namespace Onboarding.Infrastructure.Service
{
	public class EmployeeCategoryService:IEmployeeCategoryService
	{
        private readonly IEmployeeCategoryRepository _repo;
        public EmployeeCategoryService(IEmployeeCategoryRepository employeeCategoryRepository)
        {
            _repo = employeeCategoryRepository;
        }

        public Task<int> DeleteDataAsync(EmployeeCategory e)
        {
            return _repo.DeleteAsync(e);
        }

        public Task<IEnumerable<EmployeeCategory>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<EmployeeCategory> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(EmployeeCategory e)
        {
            return _repo.InsertAsync(e);
        }

        public Task<int> UpdateDataAsync(EmployeeCategory e)
        {
            return _repo.UpdateAsync(e);
        }
    }
}


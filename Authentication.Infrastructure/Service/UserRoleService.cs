using System;
using Authentication.ApplicationCore.Contract.Service;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.Infrastructure.Repository;
using Authentication.ApplicationCore.Entity;

namespace Authentication.Infrastructure.Service
{
	public class UserRoleService:IUserRoleService
	{

        private readonly IUserRoleRepository _repo;
        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            _repo = userRoleRepository;
        }

        public Task<int> DeleteDataAsync(UserRole entity)
        {
            return _repo.DeleteAsync(entity);
        }

        public Task<IEnumerable<UserRole>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<UserRole> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(UserRole entity)
        {
            return _repo.InsertAsync(entity);
        }

        public Task<int> UpdateDataAsync(UserRole entity)
        {
            return _repo.UpdateAsync(entity);
        }
    }
}


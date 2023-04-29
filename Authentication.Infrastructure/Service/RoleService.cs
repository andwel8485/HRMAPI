using System;
using Authentication.ApplicationCore.Contract.Service;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.Infrastructure.Repository;
using Authentication.ApplicationCore.Entity;

namespace Authentication.Infrastructure.Service
{
	public class RoleService:IRoleService
	{
        private readonly IRoleRepository _repo;
        public RoleService(IRoleRepository roleRepository)
        {
            _repo = roleRepository;
        }

        public Task<int> DeleteDataAsync(Role entity)
        {
            return _repo.DeleteAsync(entity);
        }

        public Task<IEnumerable<Role>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Role> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Role entity)
        {
            return _repo.InsertAsync(entity);
        }

        public Task<int> UpdateDataAsync(Role entity)
        {
            return _repo.UpdateAsync(entity);
        }
    }
}


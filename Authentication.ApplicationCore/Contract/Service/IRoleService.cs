using System;
using Authentication.ApplicationCore.Entity;

namespace Authentication.ApplicationCore.Contract.Service
{
	public interface IRoleService
	{
        public Task<IEnumerable<Role>> GetAllDataAsync();
        public Task<Role> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Role entity);
        public Task<int> DeleteDataAsync(Role entity);
        public Task<int> InsertDataAsync(Role entity);
    }
}


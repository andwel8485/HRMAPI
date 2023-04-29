using System;
using Authentication.ApplicationCore.Entity;

namespace Authentication.ApplicationCore.Contract.Service
{
	public interface IUserRoleService
	{
        public Task<IEnumerable<UserRole>> GetAllDataAsync();
        public Task<UserRole> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(UserRole entity);
        public Task<int> DeleteDataAsync(UserRole entity);
        public Task<int> InsertDataAsync(UserRole entity);
    }
}


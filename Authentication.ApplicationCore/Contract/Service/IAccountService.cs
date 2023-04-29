using System;
using Authentication.ApplicationCore.Entity;
namespace Authentication.ApplicationCore.Contract.Service
{
	public interface IAccountService
	{
        public Task<IEnumerable<Account>> GetAllDataAsync();
        public Task<Account> GetDataByIdAsync(int id);
        public Task<int> UpdateDataAsync(Account entity);
        public Task<int> DeleteDataAsync(Account entity);
        public Task<int> InsertDataAsync(Account entity);
    }
}


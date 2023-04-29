using System;
using Authentication.ApplicationCore.Contract.Service;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.Infrastructure.Repository;
using Authentication.ApplicationCore.Entity;

namespace Authentication.Infrastructure.Service
{
	public class AccountService:IAccountService
	{
        private readonly IAccountRepository _repo;
		public AccountService(IAccountRepository accountRepository)
		{
            _repo = accountRepository;
		}

        public Task<int> DeleteDataAsync(Account entity)
        {
            return _repo.DeleteAsync(entity);
        }

        public Task<IEnumerable<Account>> GetAllDataAsync()
        {
            return _repo.GetAllAsync();
        }

        public Task<Account> GetDataByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<int> InsertDataAsync(Account entity)
        {
            return _repo.InsertAsync(entity);
        }

        public Task<int> UpdateDataAsync(Account entity)
        {
            return _repo.UpdateAsync(entity);
        }
    }
}


using System;
using Authentication.Infrastructure.Data;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.ApplicationCore.Entity;
namespace Authentication.Infrastructure.Repository
{
	public class AccountRepository:BaseRepository<Account>, IAccountRepository
	{
		public AccountRepository(AutheticationDbContext context):base(context)
		{
		}
	}
}


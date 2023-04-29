using System;
using Authentication.Infrastructure.Data;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.ApplicationCore.Entity;
namespace Authentication.Infrastructure.Repository
{
	public class UserRoleRepository:BaseRepository<UserRole>, IUserRoleRepository
	{
		public UserRoleRepository(AutheticationDbContext context):base(context)
		{
		}
	}
}


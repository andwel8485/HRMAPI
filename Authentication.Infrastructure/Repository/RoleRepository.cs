using System;
using Authentication.Infrastructure.Data;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.ApplicationCore.Entity;
namespace Authentication.Infrastructure.Repository
{
	public class RoleRepository:BaseRepository<Role>, IRoleRepository
	{
		public RoleRepository(AutheticationDbContext context):base(context)
		{
		}
	}
}


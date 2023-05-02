using System;
using Microsoft.AspNetCore.Identity;
namespace Authentication.ApplicationCore.Entity
{
	public class ApplicationUser:IdentityUser
	{

		public string FirstName { get; set; }

		public string LastName { get; set; }
	}
}


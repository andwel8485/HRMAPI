using System;
using Authentication.ApplicationCore.Model;
using Authentication.ApplicationCore.Entity;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.ApplicationCore.Contract.Service;

using Authentication.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;

namespace Authentication.Infrastructure.Service
{
	public class AuthenticationService:IAuthenticationService
	{
		private readonly IAuthenticationRepository _repo;
		public AuthenticationService(IAuthenticationRepository authenticationRepository)
		{
			_repo = authenticationRepository;
		}

		public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
		{
			
			return _repo.SignUpAsync(signUpModel);
		}

        public Task<SignInResult> LoginAsync(LoginModel loginModel)
        {

            return _repo.LoginAsync(loginModel);
        }
    }
}


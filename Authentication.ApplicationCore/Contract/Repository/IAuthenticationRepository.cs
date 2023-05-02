using System;
using Microsoft.AspNetCore.Identity;
using Authentication.ApplicationCore.Model;
namespace Authentication.ApplicationCore.Contract.Repository
{
	public interface IAuthenticationRepository
	{
        public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        public Task<SignInResult> LoginAsync(LoginModel loginModel);

    }
}


using System;
using Authentication.ApplicationCore.Model;
using Microsoft.AspNetCore.Identity;

namespace Authentication.ApplicationCore.Contract.Service
{
	public interface IAuthenticationService
	{
        public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);

        public Task<SignInResult> LoginAsync(LoginModel loginModel);

    }
}


using System;
using Authentication.ApplicationCore.Contract.Repository;
using Authentication.ApplicationCore.Model;
using Authentication.ApplicationCore.Entity;
using Authentication.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;

namespace Authentication.Infrastructure.Repository
{
	public class AuthenticationRepository:IAuthenticationRepository
	{
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AuthenticationRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
		{
            _userManager = userManager;
            _signInManager = signInManager;
		}

        public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
        {
            var appUser = new ApplicationUser()
            {
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                UserName = signUpModel.Email,
                Email = signUpModel.Email
            };

            return await _userManager.CreateAsync(appUser, signUpModel.Password);
        }

        public async Task<SignInResult> LoginAsync(LoginModel loginModel)
        {

            var result = await _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false);
            return result;
        }
    }
}


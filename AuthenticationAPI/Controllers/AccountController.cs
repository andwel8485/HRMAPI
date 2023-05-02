using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Authentication.ApplicationCore.Contract.Service;
using AuthenticationAPI.Model;
using Authentication.ApplicationCore.Entity;
using Authentication.ApplicationCore.Model;

using JwtAuthenticationManager.Model;
using JwtAuthenticationManager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationService _authservice;
        private readonly JwtTokenHandler _jwtTokenHandler;
        public AccountController(IAuthenticationService authenticationService, JwtTokenHandler jwtTokenHandler)
        {
            _jwtTokenHandler = jwtTokenHandler;
            _authservice = authenticationService;
        }
        
        
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var result = await _authservice.LoginAsync(loginModel);
            if (result.Succeeded)
            {
                var authenticaionRequest = new AuthenticaionRequest()
                {
                    Username = loginModel.Username,
                    Password = loginModel.Password
                };
                var response = _jwtTokenHandler.GenerateToken(authenticaionRequest, "admin");
                return Ok(response);
            };
            return Unauthorized();
            
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            var result = await _authservice.SignUpAsync(signUpModel);
            return Ok(result);
        }
    }
}


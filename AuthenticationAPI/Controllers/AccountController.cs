using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Authentication.ApplicationCore.Contract.Service;
using AuthenticationAPI.Model;
using Authentication.ApplicationCore.Entity;
using JwtAuthenticationManager.Model;
using JwtAuthenticationManager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;
        private readonly JwtTokenHandler _jwtTokenHandler;
        public AccountController(IAccountService accountService, JwtTokenHandler jwtTokenHandler)
        {
            _jwtTokenHandler = jwtTokenHandler;
            _service = accountService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await (_service.GetAllDataAsync()));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _service.GetDataByIdAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(AccountRequest account)
        {
            Account data = new Account()
            {
                EmployeeId = account.EmployeeId,
                Email = account.Email,
                RoleId = account.RoleId,
                FirstName = account.FirstName,
                LastName = account.LastName,
                HashPassword = account.HashPassword
            };


            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(AccountRequest account)
        {
            Account data = new Account()
            {
                EmployeeId = account.EmployeeId,
                Email = account.Email,
                RoleId = account.RoleId,
                FirstName = account.FirstName,
                LastName = account.LastName,
                HashPassword = account.HashPassword
            };
            return Ok(await _service.UpdateDataAsync(data));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.GetDataByIdAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(await _service.DeleteDataAsync(data));
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(AuthenticaionRequest authenticaionRequest)
        {

            var result = _jwtTokenHandler.GenerateToken(authenticaionRequest);
            if (result != null)
            {
                return Ok(result);
            }
            return Unauthorized();
            
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onboarding.ApplicationCore.Contract.Service;
using OnboardingAPI.Model;
using Onboarding.ApplicationCore.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnboardingAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeRoleController : ControllerBase
    {
        private readonly IEmployeeRoleService _service;
        public EmployeeRoleController(IEmployeeRoleService employeeRoleService)
        {
            _service = employeeRoleService;
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
        public async Task<IActionResult> Post(EmployeeRoleRequest employeeRole)
        {
            EmployeeRole data = new EmployeeRole()
            {
                Name = employeeRole.Name,
                ABBR = employeeRole.ABBR

            };

            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EmployeeRoleRequest employeeRole)
        {
            EmployeeRole data = new EmployeeRole()
            {
                Name = employeeRole.Name,
                ABBR = employeeRole.ABBR

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
    }
}


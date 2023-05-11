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
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService employeeService)
        {
            _service = employeeService;
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
        public async Task<IActionResult> Post(EmployeeRequest employee)
        {
            Employee data = new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                SSN = employee.SSN,
                HireDate = employee.HireDate,
                EndDate = employee.EndDate,
                EmployeeCategoryId = employee.EmployeeCategoryId,
                EmployeeRoleId = employee.EmployeeRoleId,
                EmployeeStatusId = employee.EmployeeStatusId,
                Email = employee.Email,
                Address = employee.Address

            };

            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EmployeeRequest employee)
        {
            Employee data = new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                SSN = employee.SSN,
                HireDate = employee.HireDate,
                EndDate = employee.EndDate,
                EmployeeCategoryId = employee.EmployeeCategoryId,
                EmployeeRoleId = employee.EmployeeRoleId,
                EmployeeStatusId = employee.EmployeeStatusId,
                Email = employee.Email,
                Address = employee.Address
                
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


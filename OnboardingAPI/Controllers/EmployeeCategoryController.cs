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
    public class EmployeeCategoryController : ControllerBase
    {
        private readonly IEmployeeCategoryService _service;
        public EmployeeCategoryController(IEmployeeCategoryService employeeCategoryService)
        {
            _service = employeeCategoryService;
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
        public async Task<IActionResult> Post(EmployeeCategoryRequest employeeCategory)
        {
            EmployeeCategory data = new EmployeeCategory()
            {
               Description = employeeCategory.Description

            };

            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(EmployeeCategoryRequest employeeCategory)
        {
            EmployeeCategory data = new EmployeeCategory()
            {
                Description = employeeCategory.Description

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


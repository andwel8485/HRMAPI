using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Entity;
using Interview.Infrastructure.Service;
using InterviewAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    public class RecruiterController : ControllerBase
    {
        private readonly IRecruiterService _service;
        public RecruiterController(IRecruiterService recruiterService)
        {
            _service = recruiterService;
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
            return Ok(await (_service.GetDataByIdAsync(id)));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(RecruiterRequest recruiter)
        {
            Recruiter data = new Recruiter()
            {
                FirstName = recruiter.FirstName,
                LastName = recruiter.LastName,
                EmployeeId = recruiter.EmployeeId
            };

            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(RecruiterRequest recruiter)
        {
            Recruiter data = new Recruiter()
            {
                FirstName = recruiter.FirstName,
                LastName = recruiter.LastName,
                EmployeeId = recruiter.EmployeeId
            };
            return Ok(await _service.UpdateDataAsync(data));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _service.DeleteDataAsync(id));
        }
    }
}


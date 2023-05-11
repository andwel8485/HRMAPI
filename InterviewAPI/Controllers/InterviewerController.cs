﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Interview.ApplicationCore.Contract.Service;
using Interview.ApplicationCore.Entity;
using Interview.Infrastructure.Service;
using InterviewAPI.Model;

namespace InterviewAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterviewerController:ControllerBase
	{
        private readonly IInterviewerService _service;
        public InterviewerController(IInterviewerService interviewerService)
        {
            _service = interviewerService;
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
        public async Task<IActionResult> Post(InterviewerRequest interviewerRequest)
        {
            Interviewer data = new Interviewer()
            {
                FirstName = interviewerRequest.FirstName,
                LastName = interviewerRequest.LastName,
                EmployeeId = interviewerRequest.EmployeeId
            };

            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(InterviewerRequest interviewerRequest)
        {
            Interviewer data = new Interviewer()
            {
                FirstName = interviewerRequest.FirstName,
                LastName = interviewerRequest.LastName,
                EmployeeId = interviewerRequest.EmployeeId
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


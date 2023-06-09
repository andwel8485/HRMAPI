﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recruiting.ApplicationCore.Contract.Service;
using RecruitingAPI.Model;
using Recruiting.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobRequirementController : ControllerBase
    {
        private readonly IJobRequirementService _service;
        public JobRequirementController(IJobRequirementService jobRequirementService)
        {
            _service = jobRequirementService;
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
        public async Task<IActionResult> Post(JobRequirementRequest jobRequirementRequest)
        {
            JobRequirement data = new JobRequirement()
            {
                NumberOfPosition = jobRequirementRequest.NumberOfPosition,
                Title = jobRequirementRequest.Title,
                HiringManagerId = jobRequirementRequest.HiringManagerId,
                HiringManagerName = jobRequirementRequest.HiringManagerName,
                StartDate = jobRequirementRequest.StartDate,
                IsActive = jobRequirementRequest.IsActive,
                ClosedOn = jobRequirementRequest.ClosedOn,
                ClosedReason = jobRequirementRequest.ClosedReason,
                CreatedOn = jobRequirementRequest.CreatedOn,
                JobCategoryId = jobRequirementRequest.JobCategoryId,
                EmploymentTypeId = jobRequirementRequest.EmploymentTypeId
            };
       
            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(JobRequirementRequest jobRequirementRequest)
        {
            JobRequirement data = new JobRequirement()
            {
                NumberOfPosition = jobRequirementRequest.NumberOfPosition,
                Title = jobRequirementRequest.Title,
                HiringManagerId = jobRequirementRequest.HiringManagerId,
                HiringManagerName = jobRequirementRequest.HiringManagerName,
                StartDate = jobRequirementRequest.StartDate,
                IsActive = jobRequirementRequest.IsActive,
                ClosedOn = jobRequirementRequest.ClosedOn,
                ClosedReason = jobRequirementRequest.ClosedReason,
                CreatedOn = jobRequirementRequest.CreatedOn,
                JobCategoryId = jobRequirementRequest.JobCategoryId,
                EmploymentTypeId = jobRequirementRequest.EmploymentTypeId
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




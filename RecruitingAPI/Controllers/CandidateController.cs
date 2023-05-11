using System;
using System.Collections.Generic;
using System.Linq;
using Recruiting.ApplicationCore.Contract.Service;
using RecruitingAPI.Model;
using Recruiting.ApplicationCore.Entity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _service;
        public CandidateController(ICandidateService candidateService)
        {
            _service = candidateService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok (await(_service.GetAllDataAsync()));
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
        public async Task<IActionResult> Post(CandidateRequest candidate)
        {
            Candidate data = new Candidate()
            {
                FirstName = candidate.FirstName,
                LastName = candidate.LastName,
                Email = candidate.Email,
                ResumeURL = candidate.ResumeURL
            };

            return Ok(await _service.InsertDataAsync(data));
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(CandidateRequest candidateRequest)
        {
            Candidate data = new Candidate()
            {
                Id = candidateRequest.Id,
                FirstName = candidateRequest.FirstName,
                LastName = candidateRequest.LastName,
                Email = candidateRequest.Email,
                ResumeURL = candidateRequest.ResumeURL
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


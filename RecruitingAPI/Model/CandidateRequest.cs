using System;

namespace RecruitingAPI.Model
{
	public class CandidateRequest
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? ResumeURL { get; set; }
    }
}


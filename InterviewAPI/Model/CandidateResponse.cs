using System;
namespace InterviewAPI.Model
{
	public class CandidateResponse
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? ResumeURL { get; set; }
    }
}


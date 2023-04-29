using System;

namespace RecruitingAPI.Model
{
	public class SubmissionRequest
	{
        public int JobRequirementId { get; set; }
        public int CandidateId { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime ConfirmedOn { get; set; }
        public DateTime RejectedOn { get; set; }
        public int StatusId { get; set; }
    }
}


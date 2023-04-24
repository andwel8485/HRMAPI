using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.ApplicationCore.Entity
{
	public class Submission
	{
        public int Id { get; set; }

        [Required]
        public int JobRequirementId { get; set; }

        [Required]
        public int CandidateId { get; set; }

        [Required]
        public DateTime SubmittedOn { get; set; }
        public DateTime ConfirmedOn { get; set; }
        public DateTime RejectedOn { get; set; }

        [Required]
        public int StatusId { get; set; }

        public Status Status { get; set; }
        public JobRequirement JobRequirement { get; set; }
        public Candidate Candidate { get; set; }

    }
}


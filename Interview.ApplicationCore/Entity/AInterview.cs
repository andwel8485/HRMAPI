using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Interview.ApplicationCore.Entity
{
	public class AInterview
    {
		public int Id { get; set; }

		[Required]
		public int RecruiterId { get; set; }

        [Required]
        public int SubmissionId { get; set; }

        [Required]
        public int InterviewTypeId { get; set; }

		public int InterviewRound { get; set; }

        [Required]
        public DateTime ScheduledOn { get; set; }


        [Required]
        public int InterviewerId { get; set; }

        [Required]
        public int FeedBackId { get; set; }


        public Recruiter Recruiter { get; set; }

        public InterviewType InterviewType { get; set; }

        public InterviewFeedBack interviewFeedBack { get; set; }

        public Interviewer Interviewer { get; set; }
    }
}


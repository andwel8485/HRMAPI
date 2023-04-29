using System;

namespace InterviewAPI.Model
{
	public class AInterviewRequest
	{
        public int RecruiterId { get; set; }

        public int SubmissionId { get; set; }

        public int InterviewTypeId { get; set; }

        public int InterviewRound { get; set; }

        public DateTime ScheduledOn { get; set; }

        public int InterviewerId { get; set; }

        public int FeedBackId { get; set; }
    }
}


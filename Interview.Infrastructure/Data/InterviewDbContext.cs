using Microsoft.EntityFrameworkCore;
using Interview.ApplicationCore.Entity;
using System;

namespace Interview.Infrastructure.Data
{
	public class InterviewDbContext:DbContext
	{
		public InterviewDbContext(DbContextOptions<InterviewDbContext> options):base(options)
		{
		}

        public DbSet<AInterview> AInterviews { get; set; }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<InterviewType> InterviewTypes { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<InterviewFeedBack> InterviewFeedBacks { get; set; }
    }
}


using System;
using Recruiting.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Recruiting.Infrastructure.Data
{
	public class RecruitingDbContext :DbContext
	{
		public RecruitingDbContext(DbContextOptions<RecruitingDbContext> options):base(options)
		{
		}

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}


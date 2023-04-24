using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.ApplicationCore.Entity
{
	public class JobRequirement
	{
        public int Id { get; set; }

        [Required]
        public int NumberOfPosition { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string? Title { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? Description { get; set; }

        [Required]
        public int HiringManagerId { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string? HiringManagerName { get; set; }

        public DateTime StartDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime? ClosedOn { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? ClosedReason { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public int JobCategoryId { get; set; }

        [Required]
        public int EmploymentTypeId { get; set; }

        public JobCategory JobCategory { get; set; } //Manager, employee, Lead, Senior,
        public EmployeeType EmployeeType { get; set; }
        public List<Submission> Submissions { get; set; }
    }
}


using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Interview.ApplicationCore.Entity
{
	public class Recruiter
	{
		public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }

        [Required]
        public int EmployeeId { get; set; }


        public List<AInterview> Interviews { get; set; }
    }
}


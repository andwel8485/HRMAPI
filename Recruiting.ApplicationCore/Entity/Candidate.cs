using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.ApplicationCore.Entity
{
	public class Candidate
	{
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(30)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string? ResumeURL { get; set; }

        public List<Submission>? Submissions { get; set; }
    }
}


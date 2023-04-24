using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.ApplicationCore.Entity
{
	public class EmployeeType
	{
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(30)")]
        public string TypeName { get; set; }

        public List<JobRequirement> JobRequirements { get; set; }
    }
}


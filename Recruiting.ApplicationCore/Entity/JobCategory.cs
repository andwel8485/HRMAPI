using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.ApplicationCore.Entity
{
	public class JobCategory
	{
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(30)")]
        public string JobCategoryName { get; set; }

        public List<JobRequirement> JobRequirements { get; set; }
    }
}


using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruiting.ApplicationCore.Entity
{
	public class Status
	{
		public int Id { get; set; }

		[Required]
        [Column(TypeName = "varchar(300)")]
        public string Description { get; set; }

		List<Submission> Submissions { get; set; }
	}
}


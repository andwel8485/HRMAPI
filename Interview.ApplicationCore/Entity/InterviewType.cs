using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Interview.ApplicationCore.Entity
{
	public class InterviewType
	{
        public int Id { get; set; }

		[Required]
		[Column(TypeName ="varchar(300)")]
		public string Description { get; set; }

		public List<AInterview> Interviews { get; set; }
	}
}


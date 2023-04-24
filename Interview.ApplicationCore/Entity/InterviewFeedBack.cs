using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Interview.ApplicationCore.Entity
{
	public class InterviewFeedBack
	{
		public int Id { get; set; }

		[Required]
		public int Rating { get; set; }

		public string Comment { get; set; }

		public List<AInterview> Interviews { get; set; }

	}
}	


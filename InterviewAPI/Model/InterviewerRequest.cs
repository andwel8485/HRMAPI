using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InterviewAPI.Model
{
	public class InterviewerRequest
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EmployeeId { get; set; }
    }
}


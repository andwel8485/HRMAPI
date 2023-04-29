using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Model
{
	public class EmployeeStatusRequest
	{
        public string Description { get; set; }

        public string ABBR { get; set; }
    }
}


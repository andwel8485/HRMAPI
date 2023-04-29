using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Model
{
	public class EmployeeRoleRequest
	{
        public string Name { get; set; }

        public string ABBR { get; set; }
    }
}


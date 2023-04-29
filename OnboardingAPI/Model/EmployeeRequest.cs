using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnboardingAPI.Model
{
	public class EmployeeRequest
	{
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string SSN { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int EmployeeCategoryId { get; set; }

        public int EmployeeStatusId { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string EmployeeRoleId { get; set; }
    }
}


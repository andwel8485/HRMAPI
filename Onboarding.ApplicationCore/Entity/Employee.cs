using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Onboarding.ApplicationCore.Entity
{
	public class Employee
	{
		public int Id { get; set; }
        [Required]
        [Column(TypeName =("varchar(30)"))]
		public string FirstName { get; set; }

        [Required]
        [Column(TypeName = ("varchar(30)"))]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = ("varchar(30)"))]
        public string SSN { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ?EndDate { get; set; }

        [Required]
        public int EmployeeCategoryId { get; set; }

        [Required]
        public int EmployeeStatusId { get; set; }

        [Required]
        [Column(TypeName = ("varchar(300)"))]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = ("varchar(100)"))]
        public string Email { get; set; }

        [Required]
        public string EmployeeRoleId { get; set; }
    }
}


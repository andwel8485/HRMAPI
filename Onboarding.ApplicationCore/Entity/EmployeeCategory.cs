using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Onboarding.ApplicationCore.Entity
{
	public class EmployeeCategory
	{
		public int Id { get; set; }

        [Column(TypeName = ("varchar(512)"))]
        public string Description { get; set; }
    }
}


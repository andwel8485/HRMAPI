using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Onboarding.ApplicationCore.Entity
{
	public class EmployeeStatus
	{
        public int Id { get; set; }

        [Column(TypeName = ("varchar(512)"))]
        public string Description { get; set; }


        [Column(TypeName = ("varchar(16)"))]
        public string ABBR { get; set; }
    }
}


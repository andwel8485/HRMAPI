using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Authentication.ApplicationCore.Entity
{
	public class Role
	{
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Description { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}


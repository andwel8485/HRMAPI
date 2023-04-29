using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Authentication.ApplicationCore.Entity
{
	public class UserRole
	{

        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoleId { get; set; }

        public Account Account { get; set; }
        public Role Role { get; set; }

    }
}


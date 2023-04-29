using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Authentication.ApplicationCore.Entity
{
	public class Account
	{
		public int Id { get; set; }

		[Required]
		public int EmployeeId { get; set; }

		[Required]
		[Column(TypeName ="varchar(100)")]
		public string Email { get; set; }

		[Required]
		public int RoleId { get; set; }

		[Required]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(300)")]
        public string HashPassword { get; set; }

		public string ?Salt { get; set; }

		public List<UserRole> UserRoles { get; set; }
	}
}


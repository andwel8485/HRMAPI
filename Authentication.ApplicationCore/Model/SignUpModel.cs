using System;
using System.ComponentModel.DataAnnotations;

namespace Authentication.ApplicationCore.Model
{
	public class SignUpModel
	{
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Compare("ComfirmPassword")]
        public string Password { get; set; }

        [Required]

        public string ComfirmPassword { get; set; }
    }
}


﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Authentication.ApplicationCore.Model
{
	public class LoginModel
	{
		[Required]
		public string Username { get; set; }

        [Required]
        public string Password { get; set; }
	}
}


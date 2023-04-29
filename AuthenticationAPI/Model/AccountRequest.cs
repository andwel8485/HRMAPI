﻿using System;

namespace AuthenticationAPI.Model
{
	public class AccountRequest
	{
        public int EmployeeId { get; set; }

        public string Email { get; set; }

        public int RoleId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HashPassword { get; set; }
    }
}


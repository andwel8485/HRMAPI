using System;
namespace AuthenticationAPI.Model
{
    public class UserRoleRequest
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }
    }
}

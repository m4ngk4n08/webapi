using Dapper.Contrib.Extensions;
using System;

namespace api.Entities
{
    [Table("USER")]
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int RoleId { get; set; }

        public DateTime AccountExpiration { get; set; }

        public bool IsPasswordTemporary { get; set; }

        public bool ForceChangePassword { get; set; }

        public string CreatedBy { get; set; }

        public string Salt { get; set; }

        public int OrganizationId { get; set; }

        public DateTime PasswordExpiration { get; set; }
    }
}
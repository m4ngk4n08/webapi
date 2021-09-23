using api.Entities;
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repository.Mapping
{
    public class UserMap : EntityMappingBuilder<User>
    {
        public UserMap()
        {
            Map(j => j.Id)
                 .ToColumn("ID");
            Map(j => j.Username)
                 .ToColumn("USERNAME");

            Map(j => j.Password)
                 .ToColumn("PASSWORD");

            Map(j => j.FirstName)
                 .ToColumn("FIRST_NAME");

            Map(j => j.MiddleName)
                 .ToColumn("MIDDLE_NAME");

            Map(j => j.LastName)
                 .ToColumn("LAST_nAME");

            Map(j => j.Email)
                 .ToColumn("EMAIL");

            Map(j => j.RoleId)
                 .ToColumn("ROLE_ID");

            Map(j => j.AccountExpiration)
                 .ToColumn("ACCOUNT_EXPIRATION");

            Map(j => j.IsPasswordTemporary)
                 .ToColumn("IS_PASSWORD_TEMPORARY");

            Map(j => j.ForceChangePassword)
                 .ToColumn("FORCE_CHANGE_PASSWORD");

            Map(j => j.CreatedBy)
                 .ToColumn("CREATED_BY");

            Map(j => j.Salt)
                  .ToColumn("SALT");

            Map(j => j.OrganizationId)
                 .ToColumn("ORGANIZATION_ID");

            Map(j => j.PasswordExpiration)
                 .ToColumn("PASSWORD_EXPIRATION");
        }
    }
}

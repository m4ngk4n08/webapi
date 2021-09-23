using api.Entities;
using api.Repository.IRepository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public User Insert(User entity)
        {
            var sql = @"INSERT INTO [dbo].[USER] (USERNAME,
                                            PASSWORD,
                                            FIRST_NAME,
                                            MIDDLE_NAME,
                                            LAST_NAME,
                                            EMAIL,
                                            ROLE_ID,
                                            ACCOUNT_EXPIRATION,
                                            IS_PASSWORD_TEMPORARY,
                                            FORCE_CHANGE_PASSWORD,
                                            CREATED_BY,
                                            SALT,
                                            ORGANIZATION_ID,
                                            PASSWORD_EXPIRATION) 
                        OUTPUT ID INTO @Id
                        VALUES 
                                            (@Username,
                                            @Password,
                                            @FirstName,
                                            @MiddleName,
                                            @LastName,
                                            @Email,
                                            @RoleId,
                                            @AccountExpiration,
                                            1,
                                            1,
                                            @CreatedBy,
                                            @Salt,
                                            @OrganizationId,
                                            @PasswordExpiration) 
                    ";
            var parameters = new DynamicParameters();
            parameters.AddDynamicParams(entity);
            parameters.Output(entity, j => j.Id);

            _dbConnection.Execute(sql, parameters);

            return entity ?? null;
        }
    }
}

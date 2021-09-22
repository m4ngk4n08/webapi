using api.Entities;
using api.Repository.IRepository;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace api.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDbConnection _dbConnection;

        public LoginRepository(IDbConnection dbConnection)
        {
           _dbConnection = dbConnection;
        }

        public IEnumerable<User> Get()
        {
            var sql = @"select * from my_user";

            return _dbConnection.Query<User>(sql);
        }

        public User Get(User entity)
        {
            var sql = @"select * from my_user where id = @id;";

            var returnValue = _dbConnection.QueryFirstOrDefault<User>(sql, new { id = entity.Id });

            return returnValue ?? null;
        }

        public User GetUsername(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}

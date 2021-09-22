using api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repository.IRepository
{
    public interface ILoginRepository
    {
        IEnumerable<User> Get();

        User Get(User entity);

        User GetUsername(string username);

    }
}

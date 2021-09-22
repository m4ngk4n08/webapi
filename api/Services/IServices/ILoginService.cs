using api.Entities;
using System.Collections.Generic;

namespace api.Services.IServices
{
    public interface ILoginService
    {
        IEnumerable<User> Get();
        User Get(User user);
    }
}

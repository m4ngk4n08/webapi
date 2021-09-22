using api.Entities;
using api.Repository.IRepository;
using api.Services.IServices;
using AutoMapper;
using System.Collections.Generic;

namespace api.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IMapper _mapper;

        public LoginService(ILoginRepository loginRepository, IMapper mapper)
        {
            _loginRepository = loginRepository;
            _mapper = mapper;
        }

        public IEnumerable<User> Get()
        {
            return _loginRepository.Get();
        }

        public User Get(User user)
        {
            //var map = _mapper.Map<User>(user);
            var returnUser = _loginRepository.Get(user);

            return returnUser;
        }
    }
}

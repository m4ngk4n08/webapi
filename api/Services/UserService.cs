using api.Entities;
using api.Repository.IRepository;
using api.Services.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public User SignUp(User user)
        {
            var userMap = _mapper.Map<User>(user);

            _userRepository.Insert(userMap);

            throw new NotImplementedException();
        }
    }
}

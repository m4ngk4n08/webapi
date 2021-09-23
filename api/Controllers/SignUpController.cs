using api.Entities;
using api.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly IUserService _userService;

        public SignUpController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(User user)
        {
            _userService.SignUp(user);
            return NotFound();
        }
    }
}

using api.Entities;
using api.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginservice;

        public LoginController(ILoginService loginservice)
        {
            _loginservice = loginservice;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var get = _loginservice.Get();
            var test = new User()
            {
                Id = 1,
                Username = "test",
                Password = "test"
            };
            var getme = _loginservice.Get(test);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return NotFound();
        }
    }
}

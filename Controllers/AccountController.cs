using System.Linq;
using System.Threading.Tasks;
using Book_api_core.Interfaces;
using Book_api_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_api_core.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        // SignUp
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDto signUpDto)
        {
            var user = await _accountRepository.SignUp(signUpDto);

            if (user.Succeeded)
            {
                return Ok();
            }
            return BadRequest(user.Errors.Select(x => x.Description));
        }

        [HttpPut("signup")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto model)
        {
            var user = await _accountRepository.ChangePassword(model);

            if (user.Succeeded)
            {
                return Ok();
            }
            return BadRequest(user.Errors.Select(x => x.Description));
        }
    }
}
using Book_api_core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Book_api_core.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
    }
}
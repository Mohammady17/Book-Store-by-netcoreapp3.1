using System.Threading.Tasks;
using Book_api_core.Models;
using Microsoft.AspNetCore.Identity;

namespace Book_api_core.Interfaces
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUp(SignUpDto signUpDto);
    }
}
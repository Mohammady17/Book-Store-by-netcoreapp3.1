using System.Threading.Tasks;
using Book_api_core.Data;
using Book_api_core.Interfaces;
using Book_api_core.Models;
using Microsoft.AspNetCore.Identity;

namespace Book_api_core.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> SignUp(SignUpDto signUpDto)
        {
            var user = new ApplicationUser()
            {
                FirstName = signUpDto.FirstName,
                LastName = signUpDto.LastName,
                Email = signUpDto.Email,
                UserName = signUpDto.Email,
            };

            return await _userManager.CreateAsync(user, signUpDto.Password);
        }

        public async Task<IdentityResult> ChangePassword(ChangePasswordDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            return await _userManager.ChangePasswordAsync(user,
                                        model.CurrentPassword, model.NewPassword);
        }
    }
}
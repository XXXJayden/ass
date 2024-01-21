using Ass2.Models;
using Microsoft.AspNetCore.Identity;

namespace Ass2.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SigninModel model);
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Identity.Entities
{
    public class PasswordValidatorRules<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            var username = await manager.GetUserNameAsync(user);

            if (username == password)
            {
                return IdentityResult.Failed(
                    new IdentityError { Description = "Username and Password can't be equal" }
                );
            }
            if (password.Contains("password"))
            {
                return IdentityResult.Failed(
                    new IdentityError { Description = "Invalid Password. Please, be more creative!" }
                );
            }

            return IdentityResult.Success;
        }
    }
}

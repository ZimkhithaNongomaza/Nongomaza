using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Nongomaza.Models;

namespace Nongomaza.Infrastructure
{
    public class CustomUserValidator : UserValidator<IdentityUser>
    {
        public override async Task<IdentityResult> ValidateAsync(
 UserManager<IdentityUser> manager,
 IdentityUser user)
        {



            IdentityResult result = await base.ValidateAsync(manager, user);
            List<IdentityError> errors = result.Succeeded ?
            new List<IdentityError>() : result.Errors.ToList();
            if (!user.Email.ToLower().EndsWith("@example.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only example.com email addresses are allowed"
                });
            }

            return errors.Count == 0 ? IdentityResult.Success
 : IdentityResult.Failed(errors.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Microsoft.AspNetCore.Identity
{
    public interface IPasswordValidatorr<TUser> where TUser:class
    {
        Task<IdentityResult> ValidateAsync(UserManager<TUser> manager,
 TUser user, string password);
    }
}

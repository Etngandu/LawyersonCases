using LawyerOffice.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ENB.Mvc.Lawyer.Factory
{
    public class CustomClaimsFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        public CustomClaimsFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser applicationUser)
        {
            var identity = await base.GenerateClaimsAsync(applicationUser);
            identity.AddClaim(new Claim("firstname", applicationUser.FirstName));
            identity.AddClaim(new Claim("lastname", applicationUser.LastName));

            var roles = await UserManager.GetRolesAsync(applicationUser);
            foreach (var role in roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            return identity;
        }
    }
}

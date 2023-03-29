using ProjectWe.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWe.Services
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public Task<string> GenerateToken(AppUser user, IList<Claim> claims)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Security.Claims;

namespace IdentityServer.Services;

public interface IJwtTokenGenerator
{
    Task<string> GenerateToken(Database.Entities.AppUser user, IList<Claim> claims);
}

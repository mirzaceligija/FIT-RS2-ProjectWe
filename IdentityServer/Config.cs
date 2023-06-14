using IdentityServer4.Models;

namespace IdentityServer;

public class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new[]
        {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string> { "role" }
                }
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new[] {
            new ApiScope("ProjectWe.API.read"), new ApiScope("ProjectWe.API.write")
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new[]
        {
            new ApiResource("ProjectWe.API")
            {
                Scopes = new List<string> { "ProjectWe.API.read", "ProjectWe.API.write" },
                ApiSecrets = new List<Secret> { new Secret("ScopeSecret".Sha256()) },
                UserClaims = new List<string> { "role" }
            }
        };
}

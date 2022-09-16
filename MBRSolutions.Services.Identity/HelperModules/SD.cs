using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System.Collections.Generic;

namespace MBRSolutions.Services.Identity.HelperModules
{
    public static class Config
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),

            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>()
            {
                new ApiScope("jewel","Jewels Server"),
                new ApiScope(name: "read",   displayName: "Read your data."),
                new ApiScope(name: "write",  displayName: "Write your data."),
                new ApiScope(name: "delete", displayName: "Delete your data.")

            };

        public static IEnumerable<Client> Clients =>
            new List<Client>()
            {
                new Client
                {
                    ClientId="client",
                    ClientSecrets={new Secret("topsecret".Sha256()) },
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    AllowedScopes={"read","write","profile"}
                },
                 new Client
                {
                    ClientId="jewel",
                    ClientSecrets={new Secret("topsecret".Sha256()) },
                    AllowedGrantTypes=GrantTypes.Code,
                    RedirectUris={ "https://localhost:44372/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:44372/signout-callback-oidc" },
                    AllowedScopes=new List<string>
                    {
                         IdentityServerConstants.StandardScopes.OpenId,
                         IdentityServerConstants.StandardScopes.Profile,
                         IdentityServerConstants.StandardScopes.Email,
                         "jewel"
                    }
                }
            };
    }
}

using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServerForAbp.Models
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "oauthClient",
                    ClientName = "Example Client App",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("wowPassword".Sha256())
                    },
                    AllowedScopes = new List<string> {"customAPI.read"}
                },

                

                new Client
                {
                    ClientId = "TestProjectAbp",
                    ClientName = "Abp Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile
                        //IdentityServerConstants.StandardScopes.Email,
                        //"role",
                        //"customAPI.write"
                    },
                    RequireConsent = false,
                    RedirectUris = {"http://localhost:21021/signin-oidc"},
                    PostLogoutRedirectUris = {"http://localhost:21021/signout-callback-oidc"},
                    FrontChannelLogoutUri = "http://localhost:21021/signout-oidc"
                }
            };
        }
    }
}

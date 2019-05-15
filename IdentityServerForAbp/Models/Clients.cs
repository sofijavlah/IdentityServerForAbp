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
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                        //IdentityServerConstants.StandardScopes.Email,
                        //"role",
                        //"customAPI.write"
                    },
                    RequireConsent = false,
                    RedirectUris = {"http://localhost:21021/signin-oidc"},
                    PostLogoutRedirectUris = {"http://localhost:21021/signout-callback-oidc"},
                    FrontChannelLogoutUri = "http://localhost:21021/signout-oidc"
                },

                //new Client
                //{
                //    ClientId = "MyFirstApp",
                //    ClientName = "Client Example First App",
                //    AllowedGrantTypes = GrantTypes.Implicit,
                //    AllowedScopes = new List<string>
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile
                //        //IdentityServerConstants.StandardScopes.Email,
                //        //"role",
                //        //"customAPI.write"
                //    },

                //    RequireConsent = false,
                //    RedirectUris = {"http://localhost:57553/signin-oidc"},
                //    PostLogoutRedirectUris = {"http://localhost:57553/signout-callback-oidc"},
                //    FrontChannelLogoutUri = "http://localhost:57553/signout-oidc"
                //},

                //new Client
                //{
                //    ClientId = "MySecondApp",
                //    ClientName = "Client Example Second App",
                //    AllowedGrantTypes = GrantTypes.Implicit,
                //    AllowedScopes = new List<string>
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile
                //        //IdentityServerConstants.StandardScopes.Email,
                //        //"role",
                //        //"customAPI.write"
                //    },

                //    RequireConsent = false,
                //    RedirectUris = {"http://127.0.0.1:57514/signin-oidc"},
                //    PostLogoutRedirectUris = {"http://127.0.0.1:57514/signout-callback-oidc"},
                //    FrontChannelLogoutUri = "http://127.0.0.1:57514/signout-oidc"
                //}
            };
        }
    }
}

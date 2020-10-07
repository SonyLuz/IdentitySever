using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace DemoIdentityServer.Code
{
    public class Config
    {
        // scopes define the resources in your system
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                // OpenID Connect implicit flow client (Demo Client)
                new Client
                {
                    ClientId = "demo-client",
                    ClientName = "Demo Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireConsent = false,

                    RedirectUris = { "https://localhost:5001/signin-oidc"  },
                    PostLogoutRedirectUris = { "https://localhost:5001/signout-callback-oidc" },
                    ClientSecrets = {new Secret("super-secret".ToSha256(), "demo-client-secret") },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.Address,
                        "website"
                    }
                }
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "sony",
                    Password = "1234",

                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Subject, "sony1"),
                        new Claim(JwtClaimTypes.Name, "Sony"),
                        new Claim(JwtClaimTypes.GivenName, "Sony Luz"),
                        new Claim(JwtClaimTypes.FamilyName, "Luz"),
                        new Claim(JwtClaimTypes.Email, "sonyluz@teste.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "https://identityserver4.readthedocs.io/en/latest/"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'Rua teste', 'locality': 'Curitiba', 'postal_code': 00211666, 'country': 'Brazil' }", IdentityServerConstants.ClaimValueTypes.Json)

                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "Thomas",
                    Password = "1234",

                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Subject, "thomas2"),
                        new Claim(JwtClaimTypes.Name, "Thomas"),
                        new Claim(JwtClaimTypes.GivenName, "Thomas Luz"),
                        new Claim(JwtClaimTypes.FamilyName, "Luz"),
                        new Claim(JwtClaimTypes.Email, "thomasluz@teste.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://globo.com"),
                        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'Rua teste', 'locality': 'Curitiba', 'postal_code': 00211666, 'country': 'Brazil' }", IdentityServerConstants.ClaimValueTypes.Json)
                    }
                }
            };
        }
    }
}

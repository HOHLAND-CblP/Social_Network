using IdentityServer4.Models;

namespace Social_Network.Identity
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("SocialNetworkWebAPI", "Web API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                     RequireClientSecret = false,

                    // scopes that client has access to
                    AllowedScopes = { "SocialNetworkWebAPI" }
                }
            };
    }
}
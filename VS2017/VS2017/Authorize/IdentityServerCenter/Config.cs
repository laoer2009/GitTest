﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServerCenter
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetResource()
        {
            return new List<ApiResource>
            {
                new ApiResource("api","my api")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                     ClientId="client",
                     AllowedGrantTypes = GrantTypes.ClientCredentials,
                     ClientSecrets ={ new Secret("secret".Sha256())},
                    AllowedScopes = {"api"}
                }
            };
        }
    }
}

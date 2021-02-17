// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace CoreMS.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {
                new ApiResource("addressvalidator", "CoreMS APIs")
                {
                    Scopes = {
                        "addressvalidator.fullaccess"
                    }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("addressvalidator.fullaccess"),
             };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientName = "CoreMS Machine 2 Machine Client",
                    ClientId = "coremsm2m",
                    ClientSecrets = { new Secret("78195A38-796A-4EE0-8F2E-8F4EB3FECF34".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes =
                    {
                        "addressvalidator.fullaccess"
                    }
                }
            };
    }
}
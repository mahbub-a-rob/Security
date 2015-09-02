// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Authentication.JwtBearer
{
    public class AuthenticationChallengeContext : BaseControlContext<JwtBearerAuthenticationOptions>
    {
        public AuthenticationChallengeContext(HttpContext context, JwtBearerAuthenticationOptions options)
            : base(context, options)
        {
        }
    }
}
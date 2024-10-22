﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Securty.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securtyKey)
        {
            return new SigningCredentials(securtyKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}

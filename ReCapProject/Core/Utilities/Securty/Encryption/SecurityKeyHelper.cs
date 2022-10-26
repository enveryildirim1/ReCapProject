using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Securty.Encryption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securtyKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securtyKey));
        }
    }
}

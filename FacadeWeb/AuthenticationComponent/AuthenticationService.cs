using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationComponent
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool IsAuthenticated(string userName, string password)
        {
            // authentication logic
            return true;
        }
    }
}

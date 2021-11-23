using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationComponent
{
    public class AuthorizationService : IAuthorizationService
    {
        public bool IsAuthorized(string userName, string password)
        {
            // AuthorizationComponent logic
            return true;
        }
    }
}

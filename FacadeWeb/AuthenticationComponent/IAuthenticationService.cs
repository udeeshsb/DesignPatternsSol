using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationComponent
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated(string userName, string password);
    }
}

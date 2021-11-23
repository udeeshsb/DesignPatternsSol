using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationComponent
{
    public interface IAuthorizationService
    {
        bool IsAuthorized(string userName, string password);
    }
}

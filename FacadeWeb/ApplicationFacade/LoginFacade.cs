using AuthenticationComponent;
using AuthorizationComponent;
using Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationComponent;

namespace ApplicationFacade
{
    public class LoginFacade : ILoginFacade
    {
        private readonly IValidationService _validationService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IAuthorizationService _authorizationService;
        public LoginFacade()
        {
            _validationService = new ValidationService();
            _authenticationService = new AuthenticationService();
            _authorizationService = new AuthorizationService();
        }
        public bool CanLogin(string email, string password)
        {
            if (_validationService.IsValidated(email, password)
                && _authenticationService.IsAuthenticated(email, password)
                && _authorizationService.IsAuthorized(email, password))
            {
                return true;
            }

            return false;
        }
    }
}

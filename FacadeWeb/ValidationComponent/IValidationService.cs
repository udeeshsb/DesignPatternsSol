using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationComponent
{
    public interface IValidationService
    {
        bool IsValidated(string userName, string password);
    }
}

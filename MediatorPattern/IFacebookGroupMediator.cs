using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}

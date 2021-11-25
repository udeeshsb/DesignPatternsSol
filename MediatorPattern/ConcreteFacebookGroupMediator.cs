﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{ 
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> usersList = new List<User>();

        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}

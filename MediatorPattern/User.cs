using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class User
    {
        protected IFacebookGroupMediator _mediator;
        protected string name;
        public User(IFacebookGroupMediator mediator, string name)
        {
            this._mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            _mediator.SendMessage(message, this);
        }
    }
}

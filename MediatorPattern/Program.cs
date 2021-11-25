using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Mediator Design Pattern falls under the category of Behavioural Design Pattern\n");
            Console.WriteLine("\nThe Mediator Design Pattern is used to reduce the communication complexity between multiple objects. This design pattern provides a mediator object and that mediator object normally handles all the communication complexities between different objects.\n" +
                "The Mediator object acts as the communication center for all objects. That means when an object needs to communicate to another object, then it does not call the other object directly, instead, it calls the mediator object and it is the responsibility of the mediator object to route the message to the destination object.\n");
            Console.WriteLine("\nReal-time Example of Mediator Design Pattern – ATC \n\n" +
            "ATC stands for Air Traffic Control.The ATC mediator is nothing but the Air Traffic Control Tower which is available at the Airport.Please have a look at the following image.Here, you can see different flights(such as Flight 101, Flight 202, Flight 707, and Flight 808). \n\n" +
            "Suppose Flight 101 wants to land at a particular terminal in the Airport.Then what the Flight Pilot will do is he will communicate with the ATC Mediator and saying he wants to land the Flight 101 at the particular airport terminal.Then what the ATC Mediator will do is, he will check whether any flight is there at that particular terminal or not.If no flight is there, then what the ATC mediator will do is it will send a message to Pilots of other flights saying that Flight 101 is going to land and you should not land at that particular terminal. Then the ATC mediator sends a message to the Flight 101 pilot and saying you can land your flight at the particular airport terminal.Once the Flight 101 pilot got the confirmation message from the ATC Mediator then he will land the flight at that particular terminal.\n");

            Console.WriteLine();

            IFacebookGroupMediator _facebookMediator = new ConcreteFacebookGroupMediator();
            User Udeesh = new ConcreteUser(_facebookMediator, "Udeesh");
            User Karunya = new ConcreteUser(_facebookMediator, "Karunya");
            User Nivi = new ConcreteUser(_facebookMediator, "Nivi");
            User Rajesh = new ConcreteUser(_facebookMediator, "Rajesh");
            User Nirmala = new ConcreteUser(_facebookMediator, "Nirmala");
            User Deepak = new ConcreteUser(_facebookMediator, "Deepak");
            User Chandra = new ConcreteUser(_facebookMediator, "Chandra");
            User Sushma = new ConcreteUser(_facebookMediator, "Sushma");
            _facebookMediator.RegisterUser(Udeesh);
            _facebookMediator.RegisterUser(Karunya);
            _facebookMediator.RegisterUser(Nivi);
            _facebookMediator.RegisterUser(Rajesh);
            _facebookMediator.RegisterUser(Nirmala);
            _facebookMediator.RegisterUser(Deepak);
            _facebookMediator.RegisterUser(Chandra);
            _facebookMediator.RegisterUser(Sushma);
            Karunya.Send("Learn DesignPattern - this project is very good to learn Design Pattern");
            Console.WriteLine();
            Rajesh.Send("What is Design Patterns? Please explain ");
            Console.Read();

            Console.WriteLine(); 
        }
    }
}

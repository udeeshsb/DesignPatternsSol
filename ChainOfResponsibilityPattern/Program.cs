using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Chain of Responsibility pattern under Behavioral Design Pattern\n");
            Console.WriteLine("we pass an object along a 'chain' of potential handlers for that object until one of the handlers deals with the request.");

            Console.WriteLine("\nIn simple words, we can say that the chain of responsibility design pattern creates a chain of receiver objects for a given request. In this design pattern, normally each receiver contains a reference to another receiver. If one receiver cannot handle the request then it passes the same request to the next receiver and so on. One receiver handles the request in the chain or one or more receivers handle the request.\n");
            Console.WriteLine("The Chain of Responsibility design pattern avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. This pattern chains the receiving objects and passes the request along the chain until an object handles it.\n");
            Console.WriteLine("");

            Console.WriteLine("Real time scenario:\n");
            Console.WriteLine("I have a project where I have a set of indicators that must process a trading signal, but these steps don't happen at all once, rather one may happen one hour, and the next 5 or more hours later, and the sequence can be canceled by other signals Indicator 1 Pass > Indicator 2 Pass > Indicator 3 Pass I have used this pattern to process events in this manner, when the first one gives a green light, it kickstarts the next one, this is the best solution we have found.\n");
            Console.WriteLine("\nExample: ATMMachine Withdraw operation:\n");
            ATMMachine atm = new ATMMachine();
            Console.WriteLine("\n Requested Amount 4600");
            atm.withdraw(4600);
            Console.WriteLine("\n Requested Amount 1900");
            atm.withdraw(1900);
            Console.WriteLine("\n Requested Amount 600");
            atm.withdraw(600);

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------\n");

            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
            Console.Read();
        }
    }
}

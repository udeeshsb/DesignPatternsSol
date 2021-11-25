using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Observer Design Pattern. The Other names of this pattern are Producer / Consumer, Publish / Subscribe.");
            Console.WriteLine();
            Console.WriteLine("Observer design Pattern should “Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically”.");
            Console.WriteLine();
            Console.WriteLine("The Observer Design Pattern is a Software Design Pattern in which an object (called as Subject) maintains a list of its dependents (called as Observers) and notifies them automatically whenever any state changes by calling one of their methods." +
            "The Observer Design Pattern defines a one - to - many dependency between objects so that when one object’s state changes, all its dependents are notified and updated automatically.");
            Console.WriteLine();
            Console.WriteLine("Observer Design Pattern, the Observers need to be registered to the Subject. In our case, the six users are registered to the notification option of the Subject. When the state changes i.e. " +
            "Out of Stock to Available the Subject will send a notification to all the subscribers");
            Console.WriteLine();
            //Create a Product with Out Of Stock Status
            Subject RealMeOne = new Subject("RealMe one Mobile", 10000, "Out Of Stock");
            //User Udeesh will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Udeesh", RealMeOne);
            //User Karunya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Karunya", RealMeOne);
            //User Niveditha will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Niveditha", RealMeOne);
            //User Sushma will be created and user4 object will be registered to the subject
            Observer user4 = new Observer("Sushma", RealMeOne);
            //User Nirmala will be created and user5 object will be registered to the subject
            Observer user5 = new Observer("Nirmala", RealMeOne);
            //User Deepak will be created and user6 object will be registered to the subject
            Observer user6 = new Observer("Deepak", RealMeOne);

            Console.WriteLine("RealMeOne current state : " + RealMeOne.getAvailability());
            Console.WriteLine();
            // Now product is available
            RealMeOne.setAvailability("Available");
            Console.Read();
        }
    }
}

using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns are proven solutions to recurring problems and complexities in software development");
            Console.WriteLine("\nThis is Template Method design pattern");
            Console.WriteLine();
            Console.WriteLine("The Template Method design pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. This pattern lets subclasses redefine certain steps of an algorithm without changing the algorithm‘s structure");
            Console.WriteLine();
            Console.WriteLine("Template Method is a behavioral design pattern that allows you to defines a skeleton of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm’s structure.");
            Console.WriteLine();
            Console.WriteLine("Template Method Design Pattern defines a sequence of steps of an algorithm and allows the subclasses to override the steps but not allowed to change the sequence. The Key to the Template Design Pattern is that we put the general logic in the abstract parent class and let the child classes define the specifics.");
            Console.WriteLine("\nThe classes and objects participating in this pattern include: \n" +
                "-->AbstractClass (DataObject) \n" +
                "-> defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm \n" +
                "-> implements a template method defining the skeleton of an algorithm.The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects. \n" +
                "-->ConcreteClass (CustomerDataObject) \n" +
                "-> implements the primitive operations to carry out subclass-specific steps of the algorithm \n");
            Console.WriteLine();
            Console.WriteLine("Nescafe Coffee Preparation\n");
            CoffeeTemplate coffee = new NescafeCoffee();
            coffee.PrepareCoffee();
            Console.WriteLine();
            Console.WriteLine("Bru coffee preparation\n");
            coffee = new BruCoffee();
            coffee.PrepareCoffee();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Message to Log in File.");
            Console.WriteLine();
            EmailLogger emailLogger = new EmailLogger();
            emailLogger.ConsoleLogging = true;
            emailLogger.Log("Message to Log via Email.");
            Console.WriteLine();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log("Message to Log in DB.");

            Console.Read();
        }
    }
}

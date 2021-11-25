using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Strategy design pattern is a behavioral design pattern!");
            Console.WriteLine();

            Console.WriteLine("The Strategy design pattern is a behavioral design pattern that allows us to define different functionalities, put each functionality in a separate class and make their objects interchangeable.");

            Console.WriteLine("\nThe Strategy design pattern consists of the Context object which maintains the reference towards the strategy object. But it is not the only part of the puzzle. For the complete implementation, we need the Strategy object (interface) to define a way for the Context object to execute the strategy and the Concrete Strategies objects which implements the Strategy interface.");

            Console.WriteLine("\nThe Strategy design pattern is quite common in the C# language due to its various uses to provide changing behavior of a class without modifying it. This complies with the rules of the Open Closed Principle, which we talked about in one of our previous articles");

            Console.WriteLine("\nWe should use this pattern whenever we have different variations for some functionality in an object and we want to switch from one variation to another in a runtime. Furthermore, if we have similar classes in our project that only differ on how they execute some behavior, the Strategy pattern should be the right choice for us.\n");

            var reports = new List<DeveloperReport>
        {
            new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
            new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
            new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
            new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
        };
            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");

            Console.ReadKey();

            Console.WriteLine();
        }
    }
}

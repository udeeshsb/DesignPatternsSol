using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Calculation
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            bool isValid = false;
            double num1, num2;
            isValid = double.TryParse(Console.ReadLine(), out num1);
            if (!isValid)
            {
                Console.WriteLine("\nPlease enter a valid first number!");
                return;
            }

            Console.WriteLine("\nEnter second number:"); 
            isValid = double.TryParse(Console.ReadLine(), out num2);
            if (!isValid)
            {
                Console.WriteLine("\nPlease enter a valid second number!");
                return;
            }

            Console.WriteLine("\n\nEnter your choice");
            Console.WriteLine("\n1: Addition\t 2:Subtract\t 3: Multiply\t 4: Division");
            CalculateFactory objCalculateFactory = new CalculateFactory();
            int choice;
            isValid = int.TryParse(Console.ReadLine(), out choice);
            if (!isValid)
            {
                Console.WriteLine("\nPlease enter a valid choice!");
                return;
            }
            ICalculate objCal = objCalculateFactory.GetCalculation(choice);
            objCal.calculate(num1, num2);
        }
    }

    public interface ICalculate
    {
        void calculate(double num1, double num2);
    }

    class Add : ICalculate
    {
        public void calculate(double num1, double num2)
        {
            Console.WriteLine("Addition of two numbers: {0} + {1} = {2}", num1, num2, num1 + num2);
        }
    }

    class Subtract : ICalculate
    {
        public void calculate(double num1, double num2)
        {
            Console.WriteLine("Subtract of two numbers: {0} - {1} = {2}", num1, num2, num1 - num2);
        }
    }

    class Multiply : ICalculate
    {
        public void calculate(double num1, double num2)
        {
            Console.WriteLine("Multiplication of two numbers: {0} * {1} = {2}", num1, num2, num1 * num2);
        }
    }

    class Divide : ICalculate
    {
        public void calculate(double num1, double num2)
        {
            Console.WriteLine("Divide of two numbers: {0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}

using System;

namespace CommandPatternConsoleApp
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("This is Command design pattern - under behavioral design pattern!");

            Console.WriteLine("\nCommand design pattern is quite popular in C#, especially when we want to delay or queue a request’s execution or when we want to keep track of our operations. Furthermore, this possibility to keep track of our operations gives us the opportunity to undo them as well.");

            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100)); 
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 25));
            Console.WriteLine(product);
            Console.WriteLine();
            modifyPrice.UndoActions();
            Console.WriteLine(product);
        }
        private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}

using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is DecoratorPattern Pattern");
            Console.WriteLine("\nDecorator pattern is a pattern, it attaches new behaviors to existing objects by placing these objects inside special wrapper classes known as decorator class that adds additional behaviour to the existing objects.");

            //var cartDetails = new ShoppingCart().GetShoppingCartDetail();

            //DisplayReport(cartDetails);


            var cartDetails = new ShoppingCart("IN").GetShoppingCartDetail();

            DisplayReport(cartDetails);

            Console.ReadKey();
        }

        private static void DisplayReport(ShoppingCartDto dto)
        {
            var itemOrdered = dto.Orders;
            for (int i = 0; i < itemOrdered.Count; i++)
            {
                Console.WriteLine($"\nOrder Id: {itemOrdered[i].OrderId} " +
                $"Price: {itemOrdered[i].Price} " +
                $"Quantity: {itemOrdered[i].Quantity}");
            }

            Console.WriteLine($"\nTotal Price: {dto.TotalPrice}");
        }
    }
}

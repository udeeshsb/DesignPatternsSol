using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Adapter design pattern!"); 
            Console.WriteLine();
            Console.WriteLine("we have functionality in which we convert the list of car manufacturers into JSON format and write it to the screen. But instead of a list, " +
                "we have been provided with an API that provides us with all the manufacturers in the XML format!");
            Console.WriteLine();
            Console.WriteLine("We should use the Adapter class whenever we want to work with the existing class but its interface is not compatible with the rest of our code. Basically, the Adapter pattern is a middle-layer which serves as a translator between the code implemented in our project and some third party class or any other class with a different interface." +
                "Furthermore, we should use the Adapter when we want to reuse existing classes from our project but they lack a common functionality.By using the Adapter pattern in this case, we don’t need to extend each class separately and create a redundant code.");
            Console.WriteLine();
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();
        }
    }
}

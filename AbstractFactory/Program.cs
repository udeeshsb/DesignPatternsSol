using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Abstract Factory pattern! \n");

            IMobileFactory mobileFactory = new XiaomiFactory();
            mobileFactory.GetMobile(ModelType.Redmi6).GetMobile();
            mobileFactory.GetSignalStrenght(ModelType.Redmi6).ShowSignalStrength();

            Console.WriteLine();

            mobileFactory = new SamsungFactory();
            mobileFactory.GetMobile(ModelType.J7Prime).GetMobile();
            mobileFactory.GetSignalStrenght(ModelType.J7Prime).ShowSignalStrength();

            Console.ReadKey();
        }
    }
}

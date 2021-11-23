using System;
using SimpleFactory.Factory;
using SimpleFactory.ProductInterface;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Simple Factory pattern!");
            IMobile mobile = MobileFactory.CreateMobile(BrandType.Samsung);
            mobile.GetMobile();

            mobile = MobileFactory.CreateMobile(BrandType.Xiaomi);
            mobile.GetMobile();
            Console.ReadKey();
        }
    }
}

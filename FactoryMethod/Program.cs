using System;
using FactoryMethod.Factory;
using FactoryMethod.FactoryInterface; 
using FactoryMethod.ProductInterface;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is FactoryMethod pattern");

            IMobileFactory mobileFactory = new XiaomiFactory();
            IMobile mobile = mobileFactory.GetMobile(ModelType.RedmiPro);
            mobile.GetMobile();

            mobileFactory = new SamsungFactory();
            mobile = mobileFactory.GetMobile(ModelType.Galaxy);
            mobile.GetMobile(); 
        }
    }
}

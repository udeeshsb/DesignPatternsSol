using SimpleFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Product
{
    public class Xiaomi : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Xiaomi mobile created...");
        }
    }
}

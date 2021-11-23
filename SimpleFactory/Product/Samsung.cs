using SimpleFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Product
{
    public class Samsung : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung mobile created...");
        }
    }
}

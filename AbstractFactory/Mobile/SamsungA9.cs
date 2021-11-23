using System;

namespace AbstractFactory.Mobile
{
    public class SamsungA9 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung mobile created...");
        }
    }
}

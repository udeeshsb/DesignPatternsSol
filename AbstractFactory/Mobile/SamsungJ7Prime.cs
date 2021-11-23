using System;

namespace AbstractFactory.Mobile
{
    public class SamsungJ7Prime : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("SamsungJ7Prime mobile created...");
        }
    }
}

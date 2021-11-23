using System;

namespace AbstractFactory.Mobile
{
    public class XiaomiRedmi6 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmi6 mobile created...");
        }
    }
}

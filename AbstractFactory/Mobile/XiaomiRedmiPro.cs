using System;

namespace AbstractFactory.Mobile
{
    public class XiaomiRedmiPro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmiPro mobile created...");
        }
    }
}

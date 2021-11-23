using System;

namespace AbstractFactory.Signal
{
    public class SamsungA9Signal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung A9 Signal strength is good");
        }
    }
}

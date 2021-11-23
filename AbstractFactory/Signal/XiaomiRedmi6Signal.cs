using System;

namespace AbstractFactory.Signal
{
    public class XiaomiRedmi6Signal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Xiaomi Redmi6 Signal strength is good");
        }
    }
}

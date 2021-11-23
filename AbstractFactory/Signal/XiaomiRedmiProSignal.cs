using System;

namespace AbstractFactory.Signal
{
    public class XiaomiRedmiProSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Xiaomi RedmiPro Signal strength is good");
        }
    }
}

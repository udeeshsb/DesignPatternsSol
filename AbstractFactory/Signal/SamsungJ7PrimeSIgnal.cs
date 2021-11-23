using System;
using AbstractFactory;

namespace AbstractFactory.Signal
{
    public class SamsungJ7PrimeSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung Galaxy Signal strength is good");
        }
    }
}

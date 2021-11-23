using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(int type)
        {
            ICalculate obj = null;
            switch (type)
            {
                case 1:
                    obj = new Add();
                    break;
                case 2:
                    obj = new Subtract();
                    break;
                case 3:
                    obj = new Multiply();
                    break;
                case 4:
                    obj = new Divide();
                    break;
                default:
                    Console.WriteLine("Wrong entry, we will not calculate, try again!");
                    break;
            }
            return obj;
        }
    }
}

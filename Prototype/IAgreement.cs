using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public interface IAgreement
    {
        IAgreement ShallowCopy();
        void Print(string message);

        IAgreement DeepCopy();
    }
}

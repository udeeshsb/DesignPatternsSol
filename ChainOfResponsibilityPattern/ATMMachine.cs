using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ATMMachine
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();

        public ATMMachine()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.nextHandler(fiveHundredHandler);
            fiveHundredHandler.nextHandler(twoHundredHandler);
            twoHundredHandler.nextHandler(hundredHandler);
        }
        public void withdraw(long requestedAmount)
        {
            twoThousandHandler.dispatchRs(requestedAmount);
        }
    }
}

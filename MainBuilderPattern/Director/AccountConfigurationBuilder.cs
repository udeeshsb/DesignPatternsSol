using MainBuilderPattern.Builder;
using MainBuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainBuilderPattern.Director
{
    public class AccountConfigurationBuilder
    {
        public Account BuildLoanAmount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(12345);
            builder.WithLoanAmount(500000);
            builder.AddInterestRate(10.5f);

            return builder.GetAccount();
        }

        public Account BuildSavingAmount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(123445);
            builder.WithSavingBalance(); 

            return builder.GetAccount();
        }
    }
}

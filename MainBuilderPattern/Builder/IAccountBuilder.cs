using MainBuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainBuilderPattern.Builder
{
    public interface IAccountBuilder
    {
        void AddAccountNumber(long accountNumber);
        void AddCredentials(string username, string password);
        void WithLoanAmount(double loanAmount);
        void AddInterestRate(float interestRate);
        void WithSavingBalance();
        Account GetAccount(); 
    }
}

using MainBuilderPattern.Builder;
using MainBuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainBuilderPattern.ConcreteBuilder
{
    public class LoanAccountBuilder : IAccountBuilder
    {
        private Account _loanAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _loanAccount.AccountNumber = accountNumber;
        }

        public void AddCredentials(string username, string password)
        {
            _loanAccount.UserName = username;
            _loanAccount.Password = password;
        }

        public void AddInterestRate(float interestRate)
        {
            _loanAccount.InteresetRate = interestRate;
        } 

        public void WithLoanAmount(double loanAmount)
        {
            _loanAccount.LoanAmount = loanAmount;
        }

        public void WithSavingBalance()
        {
            return;
        }

        public Account GetAccount()
        {
            return _loanAccount;
        }
         
    }
}

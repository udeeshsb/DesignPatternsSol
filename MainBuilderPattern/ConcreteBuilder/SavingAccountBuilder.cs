using MainBuilderPattern.Builder;
using MainBuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainBuilderPattern.ConcreteBuilder
{
    public class SavingAccountBuilder : IAccountBuilder
    {
        private Account _savingAccount = new Account();
        public void AddAccountNumber(long accountNumber)
        {
            _savingAccount.AccountNumber = accountNumber;
        }

        public void AddCredentials(string username, string password)
        {
            _savingAccount.UserName = username;
            _savingAccount.Password = password;
        }

        public void AddInterestRate(float interestRate)
        {
            return;
        }

        public void WithLoanAmount(double loanAmount)
        {
            return;
        }

        public void WithSavingBalance()
        {
            _savingAccount.Balance = 500000;
        }

        public Account GetAccount()
        {
            return _savingAccount;
        }
    }
}

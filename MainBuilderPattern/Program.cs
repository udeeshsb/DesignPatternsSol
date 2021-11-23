using MainBuilderPattern.Builder;
using MainBuilderPattern.ConcreteBuilder;
using MainBuilderPattern.Director;
using System;

namespace MainBuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Main Builder Pattern!");

            IAccountBuilder builder = new LoanAccountBuilder();

            AccountConfigurationBuilder configBuilder = new AccountConfigurationBuilder();

            var loanAccount = configBuilder.BuildLoanAmount(builder);

            Console.WriteLine($"The loan account detail - Account number: {loanAccount.AccountNumber}" + 
                $" Loan Amount: {loanAccount.LoanAmount}");


            builder = new SavingAccountBuilder(); 

            var savingAccount = configBuilder.BuildSavingAmount(builder);

            Console.WriteLine($"The saving account detail - Account number: {savingAccount.AccountNumber}" +
                $" Balance Amount: {savingAccount.Balance}");

            Console.ReadKey();
        }
    }
}

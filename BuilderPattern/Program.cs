using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Simple Builder Pattern!");

            var bankAccount1 = new LoanAccountBuilder()
                .WithAccountNumber(1234)
                .WithCredentials("udeesh", "pwd")
                .WithLoanAmt(200000)
                .WithLoanInterestRate(8.5f)
                .Build();

            var bankAccount2 = new LoanAccountBuilder()
                .WithAccountNumber(1234) 
                .WithLoanAmt(300000)
                .WithLoanInterestRate(9.5f)
                .WithLoanStatus(true)
                .Build();

        }
    }
}

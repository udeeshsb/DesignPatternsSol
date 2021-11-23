using System;
using System.Collections.Generic;
using System.Text;

namespace MainBuilderPattern.Product
{
    public class Account
    { 
        public long AccountNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool LoanStatus { get; set; } 
        public double LoanAmount { get; set; } 
        public double Balance { get; set; }
        public float InteresetRate { get; set; }

        //public Account WithAccountNumber(long loanAccountNumber)
        //{
        //    _loanAccountNumber = loanAccountNumber;
        //    return this;
        //}

        //public Account WithCredentials(string userName, string password)
        //{
        //    _userName = userName;
        //    _password = password;
        //    return this;
        //}

        //public Account WithLoanAmt(double loanAmount)
        //{
        //    _loanAmount = loanAmount;
        //    return this;    
        //}

        //public Account WithLoanInterestRate(float interesetRate)
        //{
        //    _interesetRate = interesetRate;
        //    return this;
        //}

        //public Account WithLoanStatus(bool loanStatus)
        //{
        //    _loanStatus = loanStatus;
        //    return this;
        //}

        //public bool CanBuild()
        //{
        //    return _loanAccountNumber > 0;
        //}

        //public Account Build()
        //{
        //    return CanBuild() ? this : throw new Exception("Cannot build a account without loan account number");
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class LoanAccountBuilder
    {
        private long _loanAccountNumber;
        private string _userName;
        private string _password;
        private bool _loanStatus;
        private bool _isLoanInsured;
        private double _loanAmount;
        private float _interesetRate;
        public LoanAccountBuilder WithAccountNumber(long loanAccountNumber)
        {
            _loanAccountNumber = loanAccountNumber;
            return this;
        }

        public LoanAccountBuilder WithCredentials(string userName, string password)
        {
            _userName = userName;
            _password = password;
            return this;
        }

        public LoanAccountBuilder WithLoanAmt(double loanAmount)
        {
            _loanAmount = loanAmount;
            return this;
        }

        public LoanAccountBuilder WithLoanInterestRate(float interesetRate)
        {
            _interesetRate = interesetRate;
            return this;
        }

        public LoanAccountBuilder WithLoanStatus(bool loanStatus)
        {
            _loanStatus = loanStatus;
            return this;
        }

        private bool CanBuild()
        {
            return _loanAccountNumber > 0;
        }

        public LoanAccountBuilder Build()
        {
            return CanBuild() ? this : throw new Exception("Cannot build a account without loan account number");
        }

        ////Break the fat constructor to small constructor
        //public LoanAccountBuilder(long loanAccountNumber, string userName, string password, bool loanStatus,
        //   bool isLoanInsured, double loanAmount, float interesetRate)
        //{
        //    _loanAccountNumber = loanAccountNumber;
        //    _userName = userName;
        //    _password = password;
        //    _loanStatus = loanStatus;
        //    _isLoanInsured = isLoanInsured;
        //    _loanAmount = loanAmount;
        //    _interesetRate = interesetRate;
        //}
    }
}

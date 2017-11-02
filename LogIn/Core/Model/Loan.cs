using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class Loan
    {
        public string LoanCode { get; set; }
        public string CustomerAccountNo { get; set; }
        public string LoanDate { get; set; }
        public double PrincipalAmmount { get; set; }
        public double FileCharge { get; set; }
        public double InterestRate { get; set; }
        public int TimePeriod { get; set; }
        public double Penalty { get; set; }
        public string PaymentMode { get; set; }
        public double InterestAmmountPerMonth { get; set; }
        public double InterestAmmountPerYear { get; set; }
        public double InterestAmmountOfTimePeriod { get; set; }
        public double EMIAmmount { get; set; }
        public int NoOfEMI { get; set; }
        public string BankName { get; set; }
        public string CheckNo { get; set; }
        public double PaidAmmount  { get; set; }
        public double TotalAmmount { get; set; }





        public Loan(string loanCode, string customerAccountNo, string loanDate, double principalAmmount,
            double fileCharge,
            double interestRate, int timePeriod, double penalty, string paymentMode,
            double interestAmmountPerMonth, double interestAmmountPerYear, double interestAmmountOfTimePeriod,
            double emiAmmount, int noOfEMI,double totalammount) : this( loanCode, customerAccountNo, loanDate, principalAmmount, fileCharge,
                interestRate, timePeriod, penalty, paymentMode,
                interestAmmountPerMonth, interestAmmountPerYear, interestAmmountOfTimePeriod, emiAmmount, noOfEMI, totalammount, "", "", paidammount: 0)
        {
            
        }

        public Loan(string loanCode, string customerAccountNo, string loanDate, double principalAmmount, double fileCharge,
            double interestRate, int timePeriod, double penalty, string paymentMode,
            double interestAmmountPerMonth, double interestAmmountPerYear, double interestAmmountOfTimePeriod,
            double emiAmmount, int noOfEMI,double totalammount, string bankName, string checkNo,double paidammount)
        {
            LoanCode = loanCode;
            CustomerAccountNo = customerAccountNo;
            LoanDate = loanDate;
            PrincipalAmmount = principalAmmount;
            FileCharge = fileCharge;
            InterestRate = interestRate;
            TimePeriod = timePeriod;
            Penalty = penalty;
            PaymentMode = paymentMode;
            InterestAmmountPerMonth = interestAmmountPerMonth;
            InterestAmmountPerYear = interestAmmountPerYear;
            InterestAmmountOfTimePeriod = interestAmmountOfTimePeriod;
            EMIAmmount = emiAmmount;
            NoOfEMI = noOfEMI;
            BankName = bankName;
            CheckNo = checkNo;
            TotalAmmount = totalammount;
            PaidAmmount = paidammount;
        }
        public Loan(string loanCode, string customerAccountNo, string loanDate, double principalAmmount, double fileCharge,
           double interestRate, int timePeriod, double penalty, string paymentMode,
           double interestAmmountPerMonth, double interestAmmountPerYear, double interestAmmountOfTimePeriod,
           double emiAmmount, int noOfEMI)
        {
            LoanCode = loanCode;
            CustomerAccountNo = customerAccountNo;
            LoanDate = loanDate;
            PrincipalAmmount = principalAmmount;
            FileCharge = fileCharge;
            InterestRate = interestRate;
            TimePeriod = timePeriod;
            Penalty = penalty;
            PaymentMode = paymentMode;
            InterestAmmountPerMonth = interestAmmountPerMonth;
            InterestAmmountPerYear = interestAmmountPerYear;
            InterestAmmountOfTimePeriod = interestAmmountOfTimePeriod;
            EMIAmmount = emiAmmount;
            NoOfEMI = noOfEMI;
            
        }
    }
}
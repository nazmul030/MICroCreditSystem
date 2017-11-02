using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class CustomerLoan
    {
        public string LoanCode { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string BranchName { get; set; }
        public string CustomerAccountNo { get; set; }
        public string LoanDate { get; set; }
        public string EndDate { get; set; }
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
        public double Paidammount { get; set; }
        public int PaidEMI { get; set; }
        public CustomerLoan()
        {
            
        }
         public CustomerLoan(string loanCode, string name, string contactno, string branchname,string customerAccountNo, string loanDate, string enddate, double principalAmmount, double fileCharge,
            double interestRate, int timePeriod, double penalty, string paymentMode,
            double interestAmmountPerMonth, double interestAmmountPerYear, double interestAmmountOfTimePeriod,
            double emiAmmount, int noOfEMI, string bankName, string checkNo)
        {
             LoanCode = loanCode;
             Name = name;
             ContactNo = contactno;
             BranchName = branchname;
            CustomerAccountNo = customerAccountNo;
            LoanDate = loanDate;
             EndDate = enddate;
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
        }

         public CustomerLoan(string loanCode, string name, string contactno, string branchname, string customerAccountNo, string loanDate, string enddate, double principalAmmount, double fileCharge,
            double interestRate, int timePeriod, double penalty, string paymentMode,
            double interestAmmountPerMonth, double interestAmmountPerYear, double interestAmmountOfTimePeriod,
            double emiAmmount, int noOfEMI)
             : this(loanCode, name, contactno, branchname, customerAccountNo, loanDate, enddate, principalAmmount, fileCharge, interestRate, timePeriod, penalty, paymentMode, interestAmmountPerMonth, interestAmmountPerYear, interestAmmountOfTimePeriod, emiAmmount, noOfEMI,paidammount:0,paidemi:0)
        {
            
        }
         public CustomerLoan(string loanCode, string name, string contactno, string branchname, string customerAccountNo, string loanDate, string enddate,double principalAmmount, double fileCharge,
           double interestRate, int timePeriod, double penalty, string paymentMode,
           double interestAmmountPerMonth, double interestAmmountPerYear, double interestAmmountOfTimePeriod,
           double emiAmmount, int noOfEMI,double paidammount,int paidemi)
        {
            LoanCode = loanCode;
            Name = name;
            ContactNo = contactno;
            BranchName = branchname;
            CustomerAccountNo = customerAccountNo;
            LoanDate = loanDate;
             EndDate = enddate;
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
             Paidammount = paidammount;
             PaidEMI = paidemi;

        }
    }

}
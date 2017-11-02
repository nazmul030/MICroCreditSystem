using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.Model
{
    public class PayEMIInfo
    {
        public string CustomerAccNo { get; set; }
        public string LoanCode { get; set; }
        public string Date { get; set; }
        public double EMIammount { get; set; }
        public int NoOfEMI { get; set; }
        public string PaymentMode { get; set; }
        public double Penalty { get; set; }


        public PayEMIInfo()
        {

        }


        public PayEMIInfo(string customerAccNo, string loanCode, string date, double emiAmmount, int noOfEmi, string paymentMode)
        {
            CustomerAccNo = customerAccNo;
            LoanCode = loanCode;
            Date = date;
            EMIammount = emiAmmount;
            NoOfEMI = noOfEmi;
            PaymentMode = paymentMode;
        }
        
        public PayEMIInfo(string customerAccNo, string loanCode, string date, double emiAmmount, int noOfEmi, string paymentMode ,double penalty):this(customerAccNo,loanCode,date,emiAmmount,noOfEmi,paymentMode)
        {
            Penalty = penalty;
        }

    }
}
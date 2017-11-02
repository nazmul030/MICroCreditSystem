using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class Account
    {
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public string AccountGroup { get; set; }
        public string BranchName { get; set; }
        public double Principal { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }


        public Account(string accountNo, string accountType, string accountGroup, string branchName, double balance)
        {
            AccountNo = accountNo;
            AccountType = accountType;
            AccountGroup = accountGroup;
            BranchName = branchName;
            Balance = balance;
        }
    }
}
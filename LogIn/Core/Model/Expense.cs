using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogIn.Core.MODEL
{
    public class Expense
    {
        public string Date { get; set; }
        public double Ammount { get; set; }
        public string Description { get; set; }
        public string PaymentMode { get; set; }


        public Expense(string date, double ammount, string description, string paymentMode)
        {
            Date = date;
            Ammount = ammount;
            Description = description;
            PaymentMode = paymentMode;
        }
    }
}
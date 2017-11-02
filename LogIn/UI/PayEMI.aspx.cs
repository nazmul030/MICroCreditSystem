using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;
using LogIn.Core.Model;
using LogIn.Core.MODEL;

namespace LogIn.UI
{
    public partial class PayEMI : System.Web.UI.Page
    {
        private AccountsGateway accountsGateway = new AccountsGateway();
        private CustomersGateway customersGateway = new CustomersGateway();
        public string AccountNo;
        public string Name;
        public string Contact;
        public string PresentAddress;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["AccountNo"] != null)
                {
                    string accountNo = Request.QueryString["AccountNo"];
                    Customer customer = customersGateway.GetCustomerByAccount(accountNo);
                    CustomerLoan customerLoan = accountsGateway.GetCustomerOfCurrentLoansByAccountN0(accountNo);
                    if (customerLoan != null)
                    {
                        AccountNo = customerLoan.CustomerAccountNo;
                        Name =customerLoan.Name;
                        Contact = customerLoan.ContactNo;
                        PresentAddress = customer.PresentAddress;
                        customerViewAccNoTextBox.Text = AccountNo;
                        customeViewNameTextBox.Text = Name;
                        customerViewMobileNoTextBox.Text = Contact;
                        customerViewAddressTextBox.Text = PresentAddress;
                        principalAmmountTextBox.Text = customerLoan.PrincipalAmmount.ToString();
                        endDateTExtBox.Text = customerLoan.EndDate;
                        emiToDepositeTextBox.Text = customerLoan.EMIAmmount.ToString();
                        penaltyAmmountTextBox.Text = customerLoan.Penalty.ToString();
                        noOfEMITextBox.Text = customerLoan.NoOfEMI.ToString();
                        currentDateTextBox.Text = DateTime.Now.Date.ToString();
                    }
                }

            }
        }

        protected void noOfEMIToPayTextBox_TextChanged(object sender, EventArgs e)
        {
            if (noOfEMIToPayTextBox.Text == "")
            {
                payEMIAmmountBalanceTextBox.Text = noOfEMITextBox.ToString();
            }
            else
            {
                int noofEMItoPay = Convert.ToInt32(noOfEMIToPayTextBox.Text);
                int emiammount = Convert.ToInt32(emiToDepositeTextBox.Text);
                payEMIAmmountBalanceTextBox.Text = (noofEMItoPay * emiammount).ToString();
            }
        }

        public static string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + ConvertNumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += ConvertNumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += ConvertNumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += ConvertNumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string accountNo = customerViewAccNoTextBox.Text;
            string loanCode = loanCodeTextBox.Text;
            string customerName = customeViewNameTextBox.Text;
            string date = currentDateTextBox.Text;
            double emiAmmount = Convert.ToDouble(payEMIAmmountBalanceTextBox.Text);
            double penlaty = Convert.ToDouble(penaltyAmmountTextBox.Text);
            double ammountToPay = emiAmmount + penlaty;
            int ammount = Convert.ToInt32(Math.Ceiling(ammountToPay));
            string ammountInWords = ConvertNumberToWords(ammount);
            int noOfEmi = Convert.ToInt32(noOfEMIToPayTextBox.Text);
            string paymentMethod = paymentModeDropDownList.SelectedValue;
            PayEMIInfo payEmiInfo = new PayEMIInfo(accountNo, loanCode, date, ammountToPay, noOfEmi, paymentMethod);
            string result = accountsGateway.PayEMIofLoan(payEmiInfo);
            accountsGateway.ReduceEMI_Balance(accountNo,noOfEmi,emiAmmount);
            Response.Write("<script type='text/javascript'> alert('"+result+"')</script>");

            string description = noOfEmi + " INSTALMENT RECEIVED (" + emiAmmount + " * " + noOfEmi + " EMI)";

            Response.Redirect("InvoiceOfPaidEMI.aspx?customerAccNo=" + accountNo + "&customerName=" + customerName + "&ammountInWords=" + ammountInWords + "&paymentMethod=" + paymentMethod + "&loanCode=" + loanCode + "&description=" + description + "&ammount=" + emiAmmount.ToString());
        }

        //protected void noofEMIPaySelectDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int noofEMItoPay = Convert.ToInt32(noofEMIPaySelectDropDownList.SelectedValue);
        //    int emiammount = Convert.ToInt32(emiToDepositeTextBox);
        //    emiTotalAmmountTextBox.Text = (noofEMItoPay * emiammount).ToString();
    
        //}


    }
}
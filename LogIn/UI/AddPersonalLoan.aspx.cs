using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;
using LogIn.Core.MODEL;

namespace LogIn.UI
{
    public partial class AddPersonalLoan : System.Web.UI.Page
    {
        private AccountsGateway accountsGateway = new AccountsGateway();
        private CustomersGateway customersGateway = new CustomersGateway();
        public  string AccountNo;
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
                    Customer customers = customersGateway.GetCustomerByAccount(accountNo);
                    if (customers != null)
                    {
                        AccountNo = customers.AccountNo;
                        Name = customers.FirstName + " " + customers.LastName;
                        Contact = customers.ContactNo;
                        PresentAddress = customers.PresentAddress;
                        customerViewAccNoTextBox.Text = AccountNo;
                        customeViewNameTextBox.Text = Name;
                        customerViewMobileNoTextBox.Text = Contact;
                        customerViewAddressTextBox.Text = PresentAddress;
                    }
                }
                

            }
            if (IsPostBack)
            {
                if (Request.QueryString["AccountNo"] != null)
                {
                    string accountNo = Request.QueryString["AccountNo"];
                    Customer customers = customersGateway.GetCustomerByAccount(accountNo);
                    if (customers != null)
                    {
                        AccountNo = customers.AccountNo;
                        Name = customers.FirstName + " " + customers.LastName;
                        Contact = customers.ContactNo;
                        PresentAddress = customers.PresentAddress;
                        customerViewAccNoTextBox.Text = AccountNo;
                        customeViewNameTextBox.Text = Name;
                        customerViewMobileNoTextBox.Text = Contact;
                        customerViewAddressTextBox.Text = PresentAddress;
                    }
                }
            }

        }

        public double TotalAmmount;
        public double InterestAmmountPerMonth;
        public double InterestAmmountPerYear;
        public double InterestAmmountInTimePeriod;
        public double TotalInstallPerMonth;
        public int NoOfEMI;

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loanCode = "PL-00" + accountsGateway.GetMaxNoOfLoan().ToString(); //for loan code
                string customerAccountNo = customerViewAccNoTextBox.Text;
                string loanDate = loanDateTextBox.Text;
                double principalAmmount = Convert.ToDouble(principalAmmountTextBox.Text);
                double fileCharge = Convert.ToDouble(fileChargeTextBox.Text);
                double interestRate = Convert.ToDouble(interestRateTextBox.Text);
                int timePeriod = Convert.ToInt32(timePeriodTextBox.Text);
                double penalty = Convert.ToDouble(penaltyTextBox.Text);
                string paymentMode = "";
                if (cashPaymentModeRadioButton.Checked)
                {
                    paymentMode = "Cash";

                }
                else if (chequePaymentModeRadioButton.Checked)
                {
                    paymentMode = "Cheque";
                    chequeNoTextBox.Enabled = true;
                    bankNameTextBox.Enabled = true;
                }
                CalCulation();
                 double interestAmmountPerMonth = Convert.ToDouble(interestAmtperMonthTextBox.Text);
                    //for interest ammount per month
                double interestAmmountPerYear = Convert.ToDouble(interestAmtPerYearTextBox.Text);
                
                double interestAmmountOfTimePeriod = Convert.ToDouble(interestAmntTimePeriodTextBox.Text);

                //For calculating  total ammount
                            double perMonthInstallment = TotalInstallPerMonth;
                int noofemi = Convert.ToInt32(noOfEMIInputTextBox.Text);
                              double emiAmmount = Convert.ToDouble(emiAmmountTextBox.Text);
                string bankName = bankNameTextBox.Text;
                string chequeno = chequeNoTextBox.Text;
                double totalammount = Convert.ToDouble(totalAmmountTextBox.Text);

                Loan aLoan = new Loan(loanCode, customerAccountNo, loanDate, principalAmmount, fileCharge, interestRate, timePeriod, penalty, paymentMode, InterestAmmountPerMonth, InterestAmmountPerYear, InterestAmmountInTimePeriod, emiAmmount, noofemi, totalammount, bankName, chequeno, paidammount: 0);

                bool isLoanExists = accountsGateway.CheckIfAccountNoExists(customerAccountNo);
                if (isLoanExists == false)
                {
                    string loanResult = accountsGateway.CreateNewLoan(aLoan);
                    Response.Write("<script language='javascript'>alert('" + loanResult + "');</script>");
                    Response.Redirect("ManageCustomer.aspx");
                    ClearAll();
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Customer allready exist. ');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<span style='color:red'>" + ex.ToString() + "</span>");
            }
        }

        protected void principalAmmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void CalCulation()
        {
            if (principalAmmountTextBox.Text != null && interestAmtPerYearTextBox.Text != null)
            {
                double principalammount = Convert.ToDouble(principalAmmountTextBox.Text);
                double interestrate = Convert.ToDouble(interestRateTextBox.Text);
                int timeperiod = Convert.ToInt32(timePeriodTextBox.Text);
                InterestAmmountPerMonth = (((principalammount*interestrate)/100)/12);
                InterestAmmountPerYear = InterestAmmountPerMonth*12;
                InterestAmmountInTimePeriod = InterestAmmountPerMonth*timeperiod;
                double fileCharge = (Convert.ToDouble(fileChargeTextBox.Text)*principalammount)/100;

                TotalAmmount = principalammount + InterestAmmountInTimePeriod + fileCharge;
                TotalInstallPerMonth = TotalAmmount/timeperiod;

            }

        }

        protected void checkButton_Click(object sender, EventArgs e)
        {
            CalCulation();
            interestAmtperMonthTextBox.Text = InterestAmmountPerMonth.ToString();
            interestAmtPerYearTextBox.Text = InterestAmmountPerYear.ToString(); //For interest ammount per year.
            interestAmntTimePeriodTextBox.Text = InterestAmmountInTimePeriod.ToString(); //Total interest in the Loan Time period
            noOfEMITextBox.Text = TotalAmmount.ToString();
            emiAmmountTextBox.Text = TotalInstallPerMonth.ToString();
            totalAmmountTextBox.Text = TotalAmmount.ToString();
            noOfEMITextBox.Text = timePeriodTextBox.Text;
            //ClientScript.RegisterStartupScript(this.GetType(), "myfunction", "Calculation()", true);

        }
        private void ClearAll()
        {
            loanDateTextBox.Text = "";
            principalAmmountTextBox.Text = "";
            interestRateTextBox.Text = "";
            timePeriodTextBox.Text = "";
            emiAmmountTextBox.Text = "";
            noOfEMIInputTextBox.Text = "";
            noOfEMITextBox.Text = "";
            interestAmntTimePeriodTextBox.Text = "";
            interestAmtPerYearTextBox.Text = "";
            interestAmtperMonthTextBox.Text = "";
            fileChargeTextBox.Text = "";
            emiAmmountInputTextBox.Text = "";
            penaltyTextBox.Text = "";
            totalAmmountTextBox.Text = "";
            emiAmmountTextBox.Text = "";

        }
        

        protected void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

   
    }
}
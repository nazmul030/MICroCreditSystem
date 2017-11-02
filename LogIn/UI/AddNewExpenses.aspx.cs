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
    public partial class AddNewExpenses : System.Web.UI.Page
    {
        AccountsGateway accountsGateway = new AccountsGateway();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveExpensesButton_OnClick(object sender, EventArgs e)
        {
            string result = "";
            try
            {
                string date = addExpenseDateTextBox.Text;
                double ammount = Convert.ToDouble(ammountTextBox.Text);
                string description = descriptionTextBox.Text;
                string paymentMode = "";
                if (cashRadioButton.Checked)
                {
                    paymentMode = "Cash";
                }
                else if (chequeRadioButton.Checked)
                {
                    paymentMode = "Cheque";
                }

                Expense expense = new Expense(date, ammount, description, paymentMode);
                result = accountsGateway.AddNewExpense(expense);

                Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                ClearAll();
            }
            catch (Exception ex)
            {
                result = ex.ToString();
                Response.Write("<script language='javascript'>alert('" + result + "');</script>");
            }
        }
        private void ClearAll()
        {
            addExpenseDateTextBox.Text = "";
            ammountTextBox.Text = "";
            if (cashRadioButton.Checked)
            {
                cashRadioButton.Checked = false;
            }
            else if (chequeRadioButton.Checked)
            {
                chequeRadioButton.Checked = false;
            }
            descriptionTextBox.Text = "";
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;
using LogIn.Core.Model;
using LogIn.Core.MODEL;

namespace LogIn.UI
{
    public partial class AddNewCustomer : System.Web.UI.Page
    {
        CustomersGateway customersGateway = new CustomersGateway();
        
        AccountsGateway accountsGateway = new AccountsGateway();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["AccountNo"] != null)
                {
                    string accountno = Request.QueryString["AccountNo"];
                    CustomerInfo customer = customersGateway.GetCustomerInfoByAccount(accountno);
                    firstNameTextBox.Text = customer.CustomerFirstName;
                    lastNameTextBox.Text = customer.CustomerLastName;
                    contactTextBox.Text = customer.ContactNo;
                    presentAddressTextBox.Text = customer.PresentAddress;
                    permenantAddressTextBox.Text = customer.PermenantAddress;
                    accountNoTextBox.Text = customer.AccountNo;
                    guarentorAccountNoTextBox.Text = customer.GuarentorAccount;
                    guarentorFirstNameTextBox.Text = customer.GuarenterFirstName;
                    guarentortLastNameTextBox.Text = customer.GuarenterLastName;
                    guarentorContactNoTextBox.Text = customer.GuarenterContact;
                    guarentorEmailTextTextBox.Text = customer.GuarenterEmail;
                    parentFirstNameTextBox.Text = customer.ParentsHusbendFirstName;
                    parentLastNameTextBox.Text = customer.ParentsHusbendLastName;
                    //par.Text = customer.ParentHusbendAddress;
                    parentContactNoTextBox.Text = customer.ParentHusbendContactNo;
                    saveButton.Text = "Update";
                    pageHeaderLabel.Text = "Update Customer";

                }
            }
        }
        
        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (saveButton.Text == "Save")
            {
                try
                {
                    string firstName = firstNameTextBox.Text;
                    string lastName = lastNameTextBox.Text;
                    string dateOfBirth = dateTextBox.Text;
                    string contactNo = contactTextBox.Text;
                    string gender = "";
                    if (maleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else if (femaleRadioButton.Checked)
                    {
                        gender = "Female";
                    }
                    string photoPath = "";
                    string nidPath = "";
                    string presentAddress = presentAddressTextBox.Text;
                    string permanentAddress = permenantAddressTextBox.Text;

                    string parentHusbandFirstName = parentFirstNameTextBox.Text;
                    string parentHusbandLastName = parentLastNameTextBox.Text;
                    string parentHusbandContactNo = parentContactNoTextBox.Text;
                    string parentHusbandAddress = "";


                    string guarantorFirstName = guarentorFirstNameTextBox.Text;
                    string guarantorLastName = guarentortLastNameTextBox.Text;
                    string guarantorContactNo = guarentorContactNoTextBox.Text;
                    string guarantorAddress = "";
                    string guarantorEmail = guarentorEmailTextTextBox.Text;
                    string guarantorAccountNo = guarentorAccountNoTextBox.Text;


                    string accountNo = accountNoTextBox.Text;
                    string accountType = loanDepositeSelectDropDownList.SelectedValue;
                    string accountGroup = "";
                    string branchName = branchesDropDownList.SelectedValue.ToString();
                    double balance = 0;

                    if (firstName == "")
                    {
                        Response.Write("<span style='color:red'>Please enter customer's first name!</span>");
                    }
                    else
                    {
                        bool isCustomerExist = customersGateway.CheckIfCustomerExistsByAccountId(accountNo);
                        if (!isCustomerExist)
                        {
                            Customer customer = new Customer(firstName, lastName, dateOfBirth, gender, contactNo, branchName, presentAddress, permanentAddress, guarantorAccountNo, accountNo);
                            Account accountInfo = new Account(accountNo, accountType, accountGroup, branchName, balance);
                            Guarantor guarantorInfo = new Guarantor(guarantorFirstName, guarantorLastName, guarantorContactNo, guarantorAddress, guarantorEmail, guarantorAccountNo, accountNo);
                            ParentHusband parentHusband = new ParentHusband(accountNo, parentHusbandFirstName, parentHusbandLastName, parentHusbandContactNo, parentHusbandAddress);

                            string customerResult = customersGateway.AddNewCustomer(customer);
                            Response.Write("<script language='javascript'>alert('" + customerResult + "');</script>");

                            string accountResult = accountsGateway.CreateNewAccount(accountInfo);
                            Response.Write("<script language='javascript'>alert('" + accountResult + "');</script>");

                            string guarantorResult = customersGateway.AddNewGuarantor(guarantorInfo);
                            Response.Write("<script language='javascript'>alert('" + guarantorResult + "');</script>");

                            string parentHusbandResult = customersGateway.AddNewParentHusband(parentHusband);
                            Response.Write("<script language='javascript'>alert('" + customerResult + "');</script>");
                        }
                        else
                        {
                            Response.Write("<script language='javascript'>alert('Customer allready exist.');</script>");
                        }
                    }
                    //ResetCountryEntryPage();
                }
                catch (Exception exception)
                {
                    Response.Write(exception.Message);
                }
            }
            else if (saveButton.Text == "Update")
            {
                
            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateTextBox.Text = "";
            contactTextBox.Text = "";
            if (maleRadioButton.Checked)
            {
                maleRadioButton.Checked = false;
            }
            else if (femaleRadioButton.Checked)
            {
                femaleRadioButton.Checked = false;
            }
            presentAddressTextBox.Text = "";
            permenantAddressTextBox.Text = "";

            parentFirstNameTextBox.Text = "";
            parentLastNameTextBox.Text = "";
            parentContactNoTextBox.Text = "";
            guarentorFirstNameTextBox.Text = "";
            guarentortLastNameTextBox.Text = "";
            guarentorContactNoTextBox.Text = "";
            guarentorEmailTextTextBox.Text = "";
            guarentorAccountNoTextBox.Text = "";
            accountNoTextBox.Text = "";
        }
    }
}
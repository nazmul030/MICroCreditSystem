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
    public partial class GeneralSetting : System.Web.UI.Page
    {
        CompanyInfoesGateway companyInfoesGateway = new CompanyInfoesGateway();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCompanyInfo();
        }

        
        protected void companyEditTextBox_OnClick(object sender, EventArgs e)
        {
            string companyName = companyCurrentNameTextBox.Text;
            string address = companyCurrentAddressTextBox.Text;
            string mobileNo = companyCurrentMobileNoTextBox.Text;
            string telephoneNo = companyCurrentTelephoneTextBox.Text;
            string website = companyCurrentWebsiteTextBox.Text;
            string email = companyCurrentEmailTextBox.Text;

            companyTitleTextBox.Text = companyName;
            companyAddressTextBox.Text = address;
            mobileNoTextBox.Text = mobileNo;
            telephoneNoTextBox.Text = telephoneNo;
            companyWebsiteTextBox.Text = website;
            companyEmailTextBox.Text = email;
        }


        protected void companySaveButtonText_OnClick(object sender, EventArgs e)
        {
            string companyName = companyTitleTextBox.Text;
            string address = companyAddressTextBox.Text;
            string mobileNo = mobileNoTextBox.Text;
            string telephoneNo = telephoneNoTextBox.Text;
            string website = companyWebsiteTextBox.Text;
            string email = companyEmailTextBox.Text;

            if (companyName != "")
            {
                CompanyInfo companyInfo = new CompanyInfo(companyName, address, mobileNo, telephoneNo, website, email);

                string result = companyInfoesGateway.UpdateCompanyInfo(companyInfo);
                Response.Write("<span style='color:red'>" + result + "</span><br>");
            }
            else
            {
                Response.Write("<span style='color:red'>Enter company name first.</span><br>");
            }

            LoadCompanyInfo();
        }

        protected void LoadCompanyInfo()
        {
            CompanyInfo companyInfo = companyInfoesGateway.GetCompanyInfo();

            companyCurrentNameTextBox.Text = companyInfo.CompanyName;
            companyCurrentAddressTextBox.Text = companyInfo.Address;
            companyCurrentMobileNoTextBox.Text = companyInfo.MobileNo;
            companyCurrentTelephoneTextBox.Text = companyInfo.TelephoneNo;
            companyCurrentWebsiteTextBox.Text = companyInfo.Website;
            companyCurrentEmailTextBox.Text = companyInfo.Email;
        }        
    }
}
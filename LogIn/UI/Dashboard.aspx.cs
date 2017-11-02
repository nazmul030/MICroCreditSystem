using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;

namespace LogIn.UI
{
    public partial class Dashboard : System.Web.UI.Page
    {
        CustomersGateway customersGateway=new CustomersGateway();
        CompanyInfoesGateway companyInfoesGateway=new CompanyInfoesGateway();
        BranchesGateway branchesGateway=new BranchesGateway();
        protected void Page_Load(object sender, EventArgs e)
        {
            totalClientsLabel.Text = (customersGateway.GetNoOfClients()).ToString();
            totalLoanLabel.Text = (customersGateway.GetNoOfLoan()).ToString();
            totalLoanAmmountLabel.Text = (customersGateway.GetTotalLoanAmmount()).ToString();
            totalBranchLabel.Text = (branchesGateway.GetTotalBranches()).ToString();
        }
    }
}
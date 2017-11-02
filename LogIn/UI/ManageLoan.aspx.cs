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
    public partial class ManageLoan : System.Web.UI.Page
    {
        AccountsGateway accountsGateway=new AccountsGateway();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            List<CustomerLoan> loanlist = accountsGateway.GetCustomerLoans();
            int i = 1;
            
                manageLoanGridView.DataSource = loanlist;
                manageLoanGridView.DataBind();
            
        }
        protected void manageLoanGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            manageLoanGridView.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void manageLoanGridView_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
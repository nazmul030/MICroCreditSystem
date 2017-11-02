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
    public partial class PayEMIofLOAN : System.Web.UI.Page
    {
        AccountsGateway accountsGateway = new AccountsGateway();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        protected void payEMIGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            payEMIGridView.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        private void BindGrid()
        {
            List<CustomerLoan> loanlist = accountsGateway.GetCustomerOfCurrentLoans();
            int i = 1;

            payEMIGridView.DataSource = loanlist;
            payEMIGridView.DataBind();

        }

        protected void payEMIGridView_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;
using LogIn.Core.MODEL;

namespace LogIn.UI
{
    public partial class ExPenses : System.Web.UI.Page
    {
        AccountsGateway accountsGateway = new AccountsGateway();

        protected void Page_Load(object sender, EventArgs e)
        {
              if (!IsPostBack)
            {
               BindGrid();
              
             }
        }

        private void BindGrid()//For Bind gridview Data
        {
            List<Expense> expenseList = accountsGateway.GetAllExpenses();
            int i = 1;
            manageCapitalReturnGridview.DataSource = expenseList;
            manageCapitalReturnGridview.DataBind();

        }

        protected void manageCapitalReturnGridview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            manageCapitalReturnGridview.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        
    }
}
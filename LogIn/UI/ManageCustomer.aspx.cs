using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;
using LogIn.Core.MODEL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace LogIn.UI
{
    public partial class ManageCustomer : System.Web.UI.Page
    {
        CustomersGateway customersGateway = new CustomersGateway();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()//For Bind gridview Data
        {
            List<Customer> customers = customersGateway.GetCustomer();
            int i = 1;
            
                customerManageGridview.DataSource = customers;
                customerManageGridview.DataBind();
            
        }

        protected void customerManagerGridview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            customerManageGridview.PageIndex = e.NewPageIndex;
            BindGrid();
        }

    }
}
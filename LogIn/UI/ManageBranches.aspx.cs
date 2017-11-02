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
    public partial class ManageBranches : System.Web.UI.Page
    {
        BranchesGateway branchesGateway = new BranchesGateway();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["BranchNo"] != null)
                {
                  
                    int id = Convert.ToInt32(Request.QueryString["BranchNo"]);
                    string result = branchesGateway.DeleteBranch(id);
                    Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                }

                BindGrid();
            }
        }
        private void BindGrid()//For Bind gridview Data
        {
            List<Branch> branchesList = branchesGateway.GetAllBranches();
           
                branchesGridView.DataSource = branchesList;
                branchesGridView.DataBind();
         
        }
        protected void branchesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            branchesGridView.PageIndex = e.NewPageIndex;
            BindGrid();
        }

    }
}
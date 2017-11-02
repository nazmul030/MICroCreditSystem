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
    public partial class AddNewBranches : System.Web.UI.Page
    {
        BranchesGateway branchesGateway=new BranchesGateway();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["BranchNo"] != null)
                {

                    string branchcode = Request.QueryString["BranchNo"];
                    Branch branch = branchesGateway.GetBranchForUpdate(branchcode);
                    branchCodeTextBox.Text = branch.BranchCode;
                    branchNameTextBox.Text = branch.BranchName;
                    address_BranchesTextBox.Text = branch.Address;
                    iDHiddenTextBox.Text = (branch.Id).ToString();

                    saveBranchesText.Text = "Update";
                }

               
            }
        }

        protected void saveBranchesText_Click(object sender, EventArgs e)
        {
            string result = "";
            if (saveBranchesText.Text == "Save")
            {
                
                try
                {
                    string branchcode = branchCodeTextBox.Text;
                    string branchname = branchNameTextBox.Text;
                    string branchaddress = address_BranchesTextBox.Text;
                    
                    Branch branch = new Branch(branchcode, branchname, branchaddress);
                    if (branchesGateway.CheckIfBranchExists(branchcode) == false)
                    {
                        result = branchesGateway.AddNewBranch(branch);
                        Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                        ClearAll();
                    }
                    else
                    {
                        result = "Branch allready exists";
                        Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                        ClearAll();

                    }

                }
                catch (Exception ex)
                {
                    result = ex.ToString();
                    Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                }
            }
            if(saveBranchesText.Text=="Update")
            {
                try
                {
                    string branchcode = branchCodeTextBox.Text;
                    string branchname = branchNameTextBox.Text;
                    string branchaddress = address_BranchesTextBox.Text;
                    int id = Convert.ToInt32(iDHiddenTextBox.Text);
                    Branch branch = new Branch(id,branchcode, branchname, branchaddress);
                   
                    result = branchesGateway.UpdateBranch(branch);
                    Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                    ClearAll();
                    
                     
                }
                catch (Exception ex)
                {
                    result = ex.ToString();
                    Response.Write("<script language='javascript'>alert('" + result + "');</script>");
                }
            }
        }
        private void ClearAll()
        {
            branchNameTextBox.Text = "";
            branchCodeTextBox.Text = "";
            address_BranchesTextBox.Text = "";
        }
    }
}
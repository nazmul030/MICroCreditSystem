using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogIn.Core.DAL;

namespace LogIn
{
    public partial class Login : System.Web.UI.Page
    {
        UsersGateway usersGateway = new UsersGateway();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            string userName = logInUserNameTextbox.Text;
            string password = logInUserPasswordTextbox.Text;

            bool result = usersGateway.CheckIfUserExistsByUserNameAndPassword(userName, password);
            if (result == true)
            {
                Response.RedirectPermanent("Dashboard.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using CrystalDecisions.Web;

namespace LogIn.UI
{
    public partial class InvoiceOfPaidEMI : System.Web.UI.Page
    {
        ReportDocument rprt = new ReportDocument();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rprt.Load(Server.MapPath("~/InvoiceOfPaidEMICrystalReport.rpt"));

                CrystalReportViewer.ReportSource = rprt; 
            }
        }
    }
}
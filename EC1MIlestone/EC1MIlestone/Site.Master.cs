using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EC1MIlestone
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] != null)
            {
                if (Session["userid"].ToString() == "Admin")
                {
                    navbarSupportedContent.Visible = false;
                    navbarAdminContent.Visible = true;
                    navbarCustomerContent.Visible = false;
                }
                else
                {
                    navbarAdminContent.Visible = false; // customer nav bar
                    navbarSupportedContent.Visible = false;
                    navbarCustomerContent.Visible = true;
                }
            }
            else
            {
                navbarAdminContent.Visible = false; // admin nav bar
                navbarSupportedContent.Visible = true;
                navbarCustomerContent.Visible = false;
            }
        }
        protected void signout(object sender, EventArgs e)
        {
            Session["userid"] = null;
        }
    }
}
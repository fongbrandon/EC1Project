using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace EC1MIlestone
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection EC1AConnectionString = new SqlConnection(strcon);
                if (EC1AConnectionString.State == ConnectionState.Closed)
                {
                    EC1AConnectionString.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from AdminUser where Username='" +
                    Usernameentry.Text.Trim() + "' And Password_='" + Passwordentry.Text.Trim() +
                    "'", EC1AConnectionString);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Redirect("AdminMenu.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Indalid Credentials');</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Error');</script>");
            }
        }
    }
}
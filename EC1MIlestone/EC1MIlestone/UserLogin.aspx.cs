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
    public partial class UserLogin : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection EC1AConnectionString= new SqlConnection(strcon);
                if(EC1AConnectionString.State == ConnectionState.Closed) {
                    EC1AConnectionString.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from CustomerUser where Username='" + 
                    Usernameentry.Text.Trim() + "' And Password_='" + Passwordentry.Text.Trim()+ 
                    "'",EC1AConnectionString);
                /*SqlCommand cmd2 = new SqlCommand("Select * from AdminUser where Username='" + 
                    Usernameentry.Text.Trim() + "' And Password_='" + Passwordentry.Text.Trim()+ 
                    "'",EC1AConnectionString);*/
                SqlDataReader dr = cmd.ExecuteReader();//i can show u it is not null inside of the database
                Session["userid"] = Usernameentry.Text;
                if (dr.GetValue(3).ToString() == null)//this line it said it is showing the error
                    Session["stuff"] = "User";//anything else I am suppose to show
                else
                    Session["stuff"] = dr.GetValue(3).ToString();//it accepts whether it is an admin or a user
                //Response.Write("<script><alert>check</alert><script>");
                
                 Label1.Text = Session["stuff"].ToString();//print it right here

                if (dr.HasRows)
                {
                    Label2.Text = "check1";
                    if (Label1.Text == "User")
                    {
                        Label2.Text = "check";
                        //Label1.Text = Session["stuff"].ToString();
                            //Label1.Text = Session["stuff"].ToString();
                            Response.Redirect("LOPTest.aspx");
                    }
                    else
                    {
                        Label2.Text = "check2";
                        if (Session["stuff"].ToString() == "Admin")
                        {
                            Label2.Text = "check3";
                                Label2.Text = "check4";
                                Label1.Text = Session["stuff"].ToString();
                                Response.Redirect("AdminMenu.aspx");
                        }
                    }
                }
                else
                { // No admins,then says invalid credentials
                    Response.Write("<script>alert('Indalid Credentials');</script>");
                }
            }
            catch(Exception ex) {
                Response.Write("Error Generated. Details: " + ex.ToString());
            }
            /*Response.Write("<script>alert('Button click');</script>");*/
        }
        
    }
}
/*if (dr.HasRows) { // Checks for users 
                    Session["stuff"] = dr.GetValue(3).ToString();
                    if (Session["stuff"].ToString() == "User")
                    {
                        while (dr.Read())
                        {
                            Label1.Text = Session["stuff"].ToString();
                            Response.Redirect("LOPTest.aspx");
                        }
                    }
                }else // if not found, checks for admins
                {
                    //and here...just make a label and assign it
                    Session["stuff"] = dr.GetValue(3).ToString();
                    dr.Close();
                    dr = cmd2.ExecuteReader();
                    if(dr.HasRows)
                    {
                        if (Session["stuff"].ToString() == "Admin")
                        {
                            while (dr.Read())
                            {
                                Label1.Text = Session["stuff"].ToString();
                                Response.Redirect("AdminMenu.aspx");
                            }
                        }
                    }
                    else // No admins,then says invalid credentials
                        Response.Write("<script>alert('Indalid Credentials');</script>");
                }*/
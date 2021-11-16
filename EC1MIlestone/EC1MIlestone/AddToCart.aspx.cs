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
    public partial class AddToCart : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Session["test"];

            //ShoppingCart.SCart = (Product)Session["p1_"];
            //GridView1.DataSource = ShoppingCart.SCart;
            //GridView1.DataBind();
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cart where USERID ='" + Session["userid"] + "';", con);
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        /*GridView1.DataSource = dt;
                        GridView1.DataBind();*/
                    }
                }
                SqlCommand command = new SqlCommand("SELECT SUM(sub_total) FROM cart_table WHERE USERID ='" + Session["userid"] + "'; ", con);
                object prod_total = command.ExecuteScalar();
                //Label1.Text = prod_total.ToString();
                con.Close();
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
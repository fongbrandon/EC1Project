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
    public partial class LOPTest : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection EC1AConnectionString = new SqlConnection(strcon);
                if (EC1AConnectionString.State == ConnectionState.Closed)
                {
                    EC1AConnectionString.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into  Cart (USERID,ProductID,price_)", EC1AConnectionString);
                /*cmd.Parameters.AddWithValue("@proid",Label5);
                cmd.Parameters.AddWithValue("@price",Label2);*/
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error');</script>");
            }
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
            int item = Convert.ToInt32(e.CommandArgument.ToString()); // product id
            float price=0;
            string price1;
            try
            {
                SqlConnection EC1AConnectionString = new SqlConnection(strcon);
                if (EC1AConnectionString.State == ConnectionState.Closed)
                {
                    EC1AConnectionString.Open();
                }
                SqlCommand cmd1 = new SqlCommand("Select * from Product where product_id = '"+item+"'", EC1AConnectionString);
                SqlDataReader DR =cmd1.ExecuteReader();
                //DR.cmd1.ExecuteReader();
                if(DR.HasRows == true)
                {
                    while (DR.Read()) { 
                        //price = float.Parse(DR["product_id"].ToString);
                        price1 = DR.GetValue(4).ToString();
                        price = float.Parse(price1);
                    }
                }
                else
                {
                    price = 1;
                }
                String User = Session["userid"].ToString();//call the username
                SqlCommand cmd = new SqlCommand("Insert into  Cart (USERID,ProductID,price_) Values='"+User+","+item+","+ price+"')", EC1AConnectionString);
                SqlDataReader DR1 = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Response.Write("Error Generated. Details: " + item+price + ex.ToString());
            }//it is suppose to print the id then the price then the error
            //Response.Redirect("ProductData.aspx");
        }

    }
}
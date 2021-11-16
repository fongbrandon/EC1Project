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
    public partial class Listofproducts : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ATC_Command(object sender, CommandEventArgs e)
        {
            /*if (Quantity.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity.Text);
                total = 600 * quan1;
                Product.Text = total.ToString();
            }*/
        }

        //NOT FINISHED
        protected void ATC_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection EC1AConnectionString = new SqlConnection(strcon);
                if (EC1AConnectionString.State == ConnectionState.Closed)
                {
                    EC1AConnectionString.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into  Cart (USERID,ProductID,price_) values (@price,@ID,@USERID)", EC1AConnectionString);
                //cmd.Parameters.AddWithValue('@price', Label2.Text);
                /*cmd.Parameters.AddWithValue("@proid",Label1);
                cmd.Parameters.AddWithValue('@price',Label2);*/
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error');</script>");
            }
        }

        protected void Gridview2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int item = e.CommandArgument.Totring();// product id
            float price;
            try
            {
                SqlConnection EC1AConnectionString = new SqlConnection(strcon);
                if (EC1AConnectionString.State == ConnectionState.Closed)
                {
                    EC1AConnectionString.Open();
                }
                //SqlCommand cmd1 = new SqlCommand("Select price from Product where product_id = '" + item + "'", EC1AConnectionString);
                //SqlDataReader DR = cmd1.ExecuteReader();
                //DR.cmd1.ExecuteReader();
                /*if (DR.HasRows == true)
                {
                    price = (float)DR.GetValue(0);
                }
                else
                {
                    price = 0;
                }*/
                String User = Session["UserName"].ToString();//call the username
                //SqlCommand cmd = new SqlCommand("Insert into  Cart (USERID,ProductID,price_) Values='" + User + "," + item + "," + price + "')", EC1AConnectionString);
            }
            catch (Exception ex)
            {
                Response.Write("Error Generated. Details: " + ex.ToString());
            }
        }
    }
}
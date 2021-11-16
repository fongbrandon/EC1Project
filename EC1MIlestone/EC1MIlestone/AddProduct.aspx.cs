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
    public partial class AddProduct : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection EC1AConnectionString = new SqlConnection(strcon);
            if (EC1AConnectionString.State == ConnectionState.Closed)
            {
                EC1AConnectionString.Open();
            }
            int quan1 = Convert.ToInt32(Quantity.Text);
            string query= "Insert into  Product (product_dis,price,category,quantity,product_name) values(@prodis,@Price,@cat,@quan,@name)";
            //SqlCommand cmd = new SqlCommand("Insert into  Product (product__id,product_dis,price,category,quantity,product_name),values(" Productid.Text.Trim, prodis.Text.Trim, Price.Text.Trim, "+)", EC1AConnectionString);
            SqlCommand cmd = new SqlCommand(query, EC1AConnectionString);
            //cmd.Parameters.AddWithValue("@proid", Productid.Text);
            cmd.Parameters.AddWithValue("@prodis", prodis.Text);
            cmd.Parameters.AddWithValue("@Price",float.Parse(Price.Text));
            cmd.Parameters.AddWithValue("@cat",Category.Text);
            cmd.Parameters.AddWithValue("@quan", quan1);
            cmd.Parameters.AddWithValue("@name",Product.Text);
            try
            {
                cmd.ExecuteNonQuery();
                EC1AConnectionString.Close();
                Response.Write("Records Inserted Successfully");
            }
            catch(SqlException ep)
            {
                Response.Write("Error Generated. Details: " + ep.ToString());
            }
        }
    }
}
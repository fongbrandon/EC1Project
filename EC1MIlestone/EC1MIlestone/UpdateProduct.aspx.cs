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
    public partial class UpdateProduct : System.Web.UI.Page { 

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
            string query = "UPDATE Product SET product_dis=@prodis,price=@Price,category=@Cat,quantity=@quan,product_name=@name where product_id=@proid";
            SqlCommand cmd = new SqlCommand(query, EC1AConnectionString);
            cmd.Parameters.AddWithValue("@proid", Productid.Text);
            cmd.Parameters.AddWithValue("@prodis", prodis.Text);
            cmd.Parameters.AddWithValue("@Price", float.Parse(Price.Text));
            cmd.Parameters.AddWithValue("@cat", Category.Text);
            cmd.Parameters.AddWithValue("@quan", quan1);
            cmd.Parameters.AddWithValue("@name", Product.Text);
            try
            {
                cmd.ExecuteNonQuery();
                EC1AConnectionString.Close();
                Response.Write("Records Updated Successfully");
            }
            catch (SqlException ep)
            {
                Response.Write("Error Generated. Details: " + ep.ToString());
            }
        }
    }
}
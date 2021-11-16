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
    public partial class DeleteProduct : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["EC1AConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection EC1AConnectionString = new SqlConnection(strcon);
            try
            {
                if (EC1AConnectionString.State == ConnectionState.Closed)
                {
                    EC1AConnectionString.Open();

                    string query = "DELETE FROM Product WHERE product_id= @name";
                    SqlCommand cmd = new SqlCommand(query, EC1AConnectionString);
                    cmd.Parameters.AddWithValue("@name", Product.Text);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    EC1AConnectionString.Close();
                    Response.Write("Records Deleted Successfully");
                }
            }//that is y I am using varchar
            catch (SqlException ep)
            {
                Response.Write("Error Generated. Details: " + ep.ToString());
            }
        }
    }
}
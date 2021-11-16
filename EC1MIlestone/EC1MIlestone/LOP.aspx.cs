using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EC1MIlestone
{
    public partial class LOP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int Quantity = 0;
            Quantity = Convert.ToInt32(this.Quantity.Text);
            Product p1 = new Product("Adjustable Shocks Shock Absorber", 600.00, "Font-End", "1000", "Assets/Adjustable_Shocks_Shock_Absorber.jpeg", Quantity, "test"); // fix this up
            ShoppingCart.Add(p1);
            Session["p1_"] = p1;
            Response.Redirect("AddtoCart.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Quantity = 0;
            Quantity = Convert.ToInt32(this.Quantity1.Text);
            Product p2 = new Product("Brake Pads", 500.00, "", "1001", "Assets / Brake_Pads.jpeg", Quantity, ""); // fix this up
            ShoppingCart.Add(p2);
            Response.Redirect("AddtoCart.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int Quantity = 0;
            Quantity = Convert.ToInt32(this.Quantity2.Text);
            Product p3 = new Product("Brake Shoes", 400.00, "", "1002", "Assets/Brake_Shoes.jpeg", Quantity, "");
            ShoppingCart.Add(p3);
            Response.Redirect("AddtoCart.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int Quantity = 0;
            Quantity = Convert.ToInt32(this.Quantity3.Text);
            Product p4 = new Product("Camshaft", 100.00, "", "1003", "Assets/camshaft.jpeg", Quantity, "");
            ShoppingCart.Add(p4);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int Quantity = 0;
            Quantity = Convert.ToInt32(this.Quantity4.Text);
            Product p5 = new Product("Cylinder Head Gasket", 200.00, "", "1004", "Assets/Cylinder_Head_Gasket.jpeg", Quantity, "");
            ShoppingCart.Add(p5);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int Quantity = 0;
            Quantity = Convert.ToInt32(this.Quantity5.Text);
            Product p6 = new Product("Piston", 300.00, "", "1005", "Assets/Piston.jpeg", Quantity, "");
            ShoppingCart.Add(p6);
        }

        protected void calculate_Click(object sender, EventArgs e)
        {
            if (Quantity.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity.Text);
                total = 600 * quan1;
                Product.Text = total.ToString();
            }
        }

        protected void calculate_Click1(object sender, EventArgs e)
        {
            if (Quantity1.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity1.Text);
                total = 500 * quan1;
                Product1.Text = total.ToString();
            }
        }

        protected void calculate_Click2(object sender, EventArgs e)
        {
            if (Quantity2.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity2.Text);
                total = 400 * quan1;
                Product2.Text = total.ToString();
            }
        }

        protected void calculate_Click3(object sender, EventArgs e)
        {
            if (Quantity3.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity3.Text);
                total = 100 * quan1;
                Product3.Text = total.ToString();
            }
        }

        protected void calculate_Click4(object sender, EventArgs e)
        {
            if (Quantity4.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity4.Text);
                total = 200 * quan1;
                Product4.Text = total.ToString();
            }
        }

        protected void calculate_Click5(object sender, EventArgs e)
        {
            if (Quantity5.Text.Length > 0)
            {
                double total = 0;
                //string quan = calculate.Text;
                double quan1 = Convert.ToDouble(Quantity5.Text);
                total = 300 * quan1;
                Product5.Text = total.ToString();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace EC1MIlestone
{
    public class ShoppingCart
    {//this is where it is delared
        public static DataTable SCart = new DataTable("SCart");
        public static DataTable shopping()
        {
            DataColumn price = new DataColumn("Price");
            DataColumn quantity = new DataColumn("Quantity");
            DataColumn product_id = new DataColumn("ID");
            DataColumn subtotal = new DataColumn("Sub Total");
            DataColumn product_name = new DataColumn("Product Name");

            price.DataType = System.Type.GetType("System.Decimal");
            quantity.DataType = System.Type.GetType("System.Int32");
            product_id.DataType = System.Type.GetType("System.Int32");
            subtotal.DataType = System.Type.GetType("System.Decimal");
            product_name.DataType = System.Type.GetType("System.String");

            SCart.Columns.Add(price);
            SCart.Columns.Add(quantity);
            SCart.Columns.Add(product_id);
            SCart.Columns.Add(subtotal);
            SCart.Columns.Add(product_name);

            return SCart;
        }
        public static void Add(Product A)
        {
            for(int i=0;i< SCart.Rows.Count; i++)
            {
                if ((String)SCart.Rows[i][2] == A.product_id)
                {
                    double quantity_ = Convert.ToDouble(SCart.Rows[i][1]);
                    SCart.Rows[i][1]= quantity_+ A.quantity;
                    SCart.Rows[i][3] = (quantity_ + A.quantity) * A.price;//sub-total
                    return;
                }
            }//it store each of the attributes insite of the oject into thedatatable
            DataRow row1 = SCart.NewRow();
            row1["Price"] = A.price;
            row1["Quantity"] = A.quantity;
            row1["ID"] = A.product_id;
            row1["Product Name"] = A.product_name;
            row1["Sub Total"] = A.price * A.quantity;
        }
        public static void Remove(Product A)
        {
            for (int i = 0; i < SCart.Rows.Count; i++)
            {
                if ((String)SCart.Rows[i][2] == A.product_id)
                {
                    if ((int)SCart.Rows[i][1] - A.quantity == 0)
                    {
                        SCart.Rows[i].Delete();
                        return;
                    }
                    double quantity_ = Convert.ToDouble(SCart.Rows[i][1]);
                    SCart.Rows[i][1] = quantity_ - A.quantity;
                    SCart.Rows[i][3] = (quantity_ - A.quantity) * A.price;
                    return;
                }
            }
        }
    }
}
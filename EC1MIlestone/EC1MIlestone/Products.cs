using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC1MIlestone
{
    public class Product
    {
        public string product_name { get; set; }
        public double price { get; set; }
        public string category { get; set; }
        public string product_id { get; set; }
        public string picture { get; set; }
        public int quantity { get; set; }
        public string product_dis { get; set; }

        //it is store inside of this oject
        public Product(string product_name, double price, string category, string product_id, string picture, int quantity, string product_dis)
        {
            this.product_name = product_name;
            this.price = price;
            this.category = category;
            this.product_id = product_id;
            this.picture = picture;
            this.quantity = quantity;
            this.product_dis = product_dis;
        }
    }
}
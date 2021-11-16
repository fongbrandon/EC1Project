using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
namespace EC1MIlestone
{
    public partial class UserSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_Up_Click(object sender, EventArgs e)
        {
         var userStore = new UserStore<IdentityUser>();
         var manager = new UserManager<IdentityUser>(userStore);

         var user = new IdentityUser() { UserName = Username.Text };
         IdentityResult result = manager.Create(user, Password.Text);

         if (result.Succeeded)
         {
             //Make a label on the page to display error messages
            StatusMessage.Text = string.Format("User {0} was created successfully!", user.UserName);
                /*if (RadioButtonList1.SelectedIndex == 1)
                {
                    Session["stuff"] = "User";
                    Response.Redirect("AdminMenu.aspx");
                }if(RadioButtonList1.SelectedIndex == 2)
                {
                    Session["stuff"] = "Admin";
                    Response.Redirect("LOPTest.aspx");
                }*/
         }
         else
         {
            StatusMessage.Text = result.Errors.FirstOrDefault();
         }
        }

      
    }
}
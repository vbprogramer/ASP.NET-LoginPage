using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitLogin
{
    public partial class Header : System.Web.UI.UserControl
    {
        GitLogin.Tools.User k = new Tools.User();
        protected void Page_Load(object sender, EventArgs e)
        {
            k = (GitLogin.Tools.User)Session["User"];


            try
            {
                lblUserInfo.Text = "User: " + (k.FirstName1 + " " + k.LastName1);
            }
            catch (Exception ex)
            {
                Session["User"] = null;
                Response.Redirect("Login.aspx");
            }
        }
        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}
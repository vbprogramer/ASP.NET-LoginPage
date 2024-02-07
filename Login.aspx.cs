using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace GitLogin
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected MySqlConnection Connection1;
        protected MySqlCommand CmdSelectUser;
        protected void Page_Load(object sender, EventArgs e)
        {
           /* if (!IsPostBack)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "scr", @"
			<script language='javascript'>
				var obtn=document.getElementById('" + txtUserName.ClientID + @"');
				obtn.focus();
			</script>");
            }*/
        }
        override protected void OnInit(EventArgs e)
        {
            InitializeComponent();
            base.OnInit(e);
        }
        private void InitializeComponent()
        {
            this.Connection1 = new MySqlConnection();
            this.CmdSelectUser = new MySqlCommand();
            // 
            // Connection1
            // 
            this.Connection1.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GitLoginConnectionString"].ConnectionString;
            // 
            // CmdSelectUser
            // 
            this.CmdSelectUser.CommandText = "SELECT users.*, Username AS Username, Password AS Password FROM users WHERE (Username = @Username) AND (Password = @Password)";
            this.CmdSelectUser.Connection = this.Connection1;
            this.CmdSelectUser.Parameters.Add(new MySqlParameter("@Username", MySqlDbType.VarChar, 20));
            this.CmdSelectUser.Parameters.Add(new MySqlParameter("@Password", MySqlDbType.VarChar, 20));

        }
        private void LoginUser(string userName, string password)
        {
            try
            {
                Connection1.Open();
                CmdSelectUser.Parameters["@UserName"].Value = userName;
                CmdSelectUser.Parameters["@Password"].Value = password;

                MySqlDataReader dr = CmdSelectUser.ExecuteReader();

                if (dr.Read())
                {

                    GitLogin.Tools.User k = new Tools.User();
                    k.ID1 = int.Parse(dr["Id"].ToString());
                    k.UserName1 = txtUserName.Text.Trim();
                    if (dr["FirstName"] != DBNull.Value)
                        k.FirstName1 = dr["FirstName"].ToString();
                    else
                        k.FirstName1 = "";
                    if (dr["LastName"] != DBNull.Value)
                        k.LastName1 = dr["LastName"].ToString();
                    else
                        k.LastName1 = "";
                    if (dr["Vocation"] != DBNull.Value)
                        k.Vocation1 = dr["Vocation"].ToString();
                    else
                        k.Vocation1 = "";
                    dr.Close();

                    /*********************************************/

                    Session["User"] = k;

                    /*********************************************/



                    if (Request["Path"] != null)
                        Response.Redirect(Request["Path"].ToString());
                    else
                        Response.Redirect("Index.aspx", false);

                }
                else
                {
                    lblMessage.Text = "Failed to login to the system. Try again!";
                    dr.Close();
                }

            }
            catch (Exception ex)
            {
                Session["User"] = null;
            }
            finally
            {
                Connection1.Close();
            }
        }
        protected void btnPrijava_Click(object sender, System.EventArgs e)
        {
            LoginUser(txtUserName.Text.Trim(), txtPassword.Text);
        }
    }
}
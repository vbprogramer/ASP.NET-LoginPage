using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace GitLogin.Tools
{
    public class User
    {
        private int ID = 0;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }
        private string UserName;

        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private string LastName;

        public string LastName1
        {
            get { return LastName; }
            set { LastName = value; }
        }
        private string FirstName;

        public string FirstName1
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        private string Vocation;

        public string Vocation1
        {
            get { return Vocation; }
            set { Vocation = value; }
        }
    }
}
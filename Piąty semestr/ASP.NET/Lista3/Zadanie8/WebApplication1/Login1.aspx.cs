using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected const string accept_login = "admin";
        protected const string accept_passwd = "paswd";
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label.Text = "";
        }

        protected void Log_Click(object sender, EventArgs e)
        {
            this.Session.Add("url", this.Request.Url);

            if(this.Username.Text == accept_login && this.Password.Text == accept_passwd)
            {
                var cookie = new HttpCookie("log");
                cookie.Value = this.Username.Text;
                this.Response.SetCookie(cookie);
            }
            Response.Redirect("/Index.aspx");
        }
    }
}
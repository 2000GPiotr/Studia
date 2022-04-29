using InfrastructureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie2
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void login_Click(object sender, EventArgs e)
        {
            
            if (Membership.ValidateUser(username.Text, password.Text))
            {
                //FormsAuthentication.RedirectFromLoginPage(username.Text, false);

                FormsAuthenticationTicket ticket =
                    new FormsAuthenticationTicket(1, username.Text, DateTime.Now, DateTime.Now.AddMinutes(60), false, string.Empty);

                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                this.Response.AppendCookie(cookie);

                var returnUrl = this.Request.QueryString["ReturnUrl"];
                if(string.IsNullOrEmpty(returnUrl))
                {
                    returnUrl = FormsAuthentication.DefaultUrl;
                }

                this.Response.Redirect(returnUrl);
            }
            else
            {
                loginLabel.Text = "Błąd logowania";
            }
            Response.Redirect("WebForm1.aspx");
        }
    }
}
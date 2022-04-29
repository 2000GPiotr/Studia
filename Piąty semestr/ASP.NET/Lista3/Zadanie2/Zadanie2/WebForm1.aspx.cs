using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            var cookie = new HttpCookie("ciastko");
            cookie.Value = this.name.Text;
            this.Response.SetCookie(cookie);
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            if(this.Request.Cookies["ciastko"] != null)
            {
                var c = this.Request.Cookies["ciastko"];
                this.Response.Cookies.Remove("ciastko");
                this.lb.Text = "Usunięto";
                c.Expires = DateTime.Now.AddHours(-1);

                this.Response.SetCookie(c);
            }
            
        }

        protected void Show_Click(object sender, EventArgs e)
        {
            var qs = this.Request.Cookies;

            if (qs["ciastko"] != null)
            {
                var c = qs["ciastko"];
                this.lb.Text = c.Value;
            }
            else
            {
                this.lb.Text = "";
            }
        }
    }
}
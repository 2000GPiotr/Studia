using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var qs = this.Request.Cookies;
            if(qs["log"] == null)
            {
                var url = this.Session["url"].ToString();
                Response.Redirect(url);
            }

        }
    }
}
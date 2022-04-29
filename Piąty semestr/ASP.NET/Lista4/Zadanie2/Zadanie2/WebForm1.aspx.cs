using InfrastructureLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            l4.Text = this.User.Identity.IsAuthenticated ? this.User.Identity.Name : "niezalogowany";
            #region testy
            /*try
            {
                using(var context = new DataClasses1DataContext(@"server=.\sqlexpress;database=Z2;integrated security=true"))
                {
                    l1.Text = "OK";
                     var name =
                        context.User
                        .Where(p => p.name == "Jan")
                        .Take(1);

                    foreach(var user in name)
                    {
                        var paswd =
                            context.Passwd
                            .Where(p => p.ID == user.ID)
                            .Take(1);
                        
                        foreach(var pas in paswd)
                        {
                            l3.Text = string.Format("{0} {1} {2} {3}", user.name, user.email, pas.password1, pas.date);
                        }
                        
                    }

                    foreach(var user in context.User)
                    {
                        string q = string.Format("{0} {1} {2}  |  ", user.ID, user.name, user.email);
                        l2.Text += q;
                    }
                }
            }
            catch(Exception ex)
            {
                l1.Text =ex.Message;
            }*/
            #endregion

        }
    }
}
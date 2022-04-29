using InfrastructureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string hash(string p, string s, int a)
        {
            for(int i=0; i<a; i++)
            {
                p = s + p;
                p = ComputeSha256Hash(p);
            }
            return p;
        }
        protected void registerConfirm_Click(object sender, EventArgs e)
        {
            using (var context = new DataClasses1DataContext(@"server=.\sqlexpress;database=Z2;integrated security=true"))
            {
                var newUser = new User
                {
                    name = registerName.Text,
                    email = registerEmail.Text
                };

                var rand = new Random();
                int r = rand.Next(5, 10);

                var s = Guid.NewGuid().ToString();

                var newPaswd = new Passwd
                {
                    password1 = hash(registerPassword.Text, s, r).ToString(),
                    rounds = r,
                    date = DateTime.Now,
                    salt = s
                };

                context.User.InsertOnSubmit(newUser);
                context.Passwd.InsertOnSubmit(newPaswd);

                context.SubmitChanges();

                this.Response.Redirect("WebForm1.aspx");
            }
        }
    }
}
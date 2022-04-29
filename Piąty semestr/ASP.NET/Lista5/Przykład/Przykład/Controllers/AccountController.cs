using Przykład.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Przykład.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Logon()
        {
            var model = new AccountLogonModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Logon(AccountLogonModel model)
        {
            var a = model.Username;
            var b = model.Password;
            if (this.ModelState.IsValid)
            {
                if (a == b)
                {
                    
                    FormsAuthentication.RedirectFromLoginPage(a, false);
                    return new EmptyResult();
                }
                else
                {
                    this.ViewBag.Message = "Błąd";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}
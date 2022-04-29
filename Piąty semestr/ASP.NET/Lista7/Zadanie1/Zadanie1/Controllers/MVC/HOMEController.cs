using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadanie1.Controllers.MVC
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult Index()
        {
            return Content("HOME MVC");
        }
    }
}
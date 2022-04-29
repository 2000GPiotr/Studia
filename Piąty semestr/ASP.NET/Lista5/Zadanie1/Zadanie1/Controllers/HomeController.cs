using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadanie1.Models.Home;

namespace Zadanie1.Controllers
{
    public class HomeController : Controller
    {
        HomeIndexModel model = new HomeIndexModel();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            
            for(int i=0; i<10; i++)
            {
                model.Ex = new int[10];
            }
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            
            return Redirect("/Home/Print");
        }

        public ActionResult Print(HomeIndexModel model1)
        {
            model1.Ex[0]++;
            //return Redirect();
            return View();
        }
    }
}
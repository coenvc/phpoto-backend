using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KoldingPhoto.Controllers
{
    public class HomeController : Controller
    {

        //private User model = new User();

        public ActionResult Index()
        {
            return View();
        }


        //public ActionResult Index(string username, string password)
        //{
        //    if (model.LogGebruikerIn(username, password) != null)
        //    {
        //        Session["username"] = username;
        //        Session.Timeout = 30;
        //        return RedirectToAction();
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //} 

        public ActionResult Timeline()
        {
            return View("Timeline");
        }



    }
}
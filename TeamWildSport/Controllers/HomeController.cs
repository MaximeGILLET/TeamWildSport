using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook;
using System.Configuration;

namespace TeamWildSport.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Events()
        {

            var client = new FacebookClient();
            client.AppId = ConfigurationManager.AppSettings["FbAppId"];
            client.AppSecret = ConfigurationManager.AppSettings["FbAppSecret"];
            return View();
        }
    }
}
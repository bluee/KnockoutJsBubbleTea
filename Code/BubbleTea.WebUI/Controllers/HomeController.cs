using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbleTea.WebUI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Main page showing shopping cart
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}
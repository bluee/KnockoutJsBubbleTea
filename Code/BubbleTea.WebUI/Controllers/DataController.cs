using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace BubbleTea.WebUI.Controllers
{
    [OutputCache(Duration = 6000, Location = OutputCacheLocation.Any)]
    public class DataController : Controller
    {
        private CartDbEntities db = new CartDbEntities();

        [HttpGet]
        //
        // GET: /Data/GetFlavors
        public JsonResult GetFlavors()
        {
            //IQueryable
            return Json(db.Flavors, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        //
        // GET: /Data/GetToppings
        public JsonResult GetToppings()
        {
            //IQueryable
            return Json(db.Toppings, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        //
        // GET: /Data/GetToppings
        public JsonResult GetProducts()
        {
            //IQueryable
            return Json(db.Products, JsonRequestBehavior.AllowGet);
        }

    }
}
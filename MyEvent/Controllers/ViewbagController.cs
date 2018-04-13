using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEvent.Controllers
{
    public class ViewbagController : Controller
    {
        // GET: Viewbag
        public ActionResult Index()
        {
            ViewBag.Anything = "ViewBag is a dynamic object which is a member of Controller class!";
            return View();
        }
    }
}
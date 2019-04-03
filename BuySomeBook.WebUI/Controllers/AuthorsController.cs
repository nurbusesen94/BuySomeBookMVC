using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuySomeBook.WebUI.Controllers
{
    public class AuthorsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PageTitle = "- Yazarlar";
            return View();
        }
    }
}
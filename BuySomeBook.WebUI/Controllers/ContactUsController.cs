using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuySomeBook.WebUI.Controllers
{
    public class ContactUsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PageTitle = "- Bize Ulaşın";
            return View();
        }
    }
}
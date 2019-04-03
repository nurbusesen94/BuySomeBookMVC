using BuySomeBook.BLL.Repositories;
using BuySomeBook.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuySomeBook.WebUI.Controllers
{
    public class HomeController : Controller
    {
        Repository<Product> repoProduct = new Repository<Product>();

        public ActionResult Index()
        {
            return View(repoProduct.GetAll().Include(i=>i.Author).Include(i => i.Pictures).ToList());
        }       
    }
}
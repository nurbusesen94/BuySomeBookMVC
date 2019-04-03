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
    public class SingleProductController : Controller
    {
        Repository<Product> repoProduct = new Repository<Product>();
        // GET: SingleProduct
        public ActionResult Index(int ID)
        {
            return View(repoProduct.GetAll().Include(i => i.Author).Include(i => i.Pictures).FirstOrDefault(f => f.ID == ID));
        }
    }
}
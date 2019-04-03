using BuySomeBook.BLL.Repositories;
using BuySomeBook.BOL.Entities;
using BuySomeBook.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuySomeBook.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        Repository<Category> repoCategory = new Repository<Category>();
        Repository<Brand> repoBrand = new Repository<Brand>();
        Repository<Product> repoProduct = new Repository<Product>();

        public ActionResult Index()
        {
            AllProductVM allProductVM = new AllProductVM
            {
                Categories = repoCategory.GetAll().Include(i => i.Children).Include(i => i.Products).ToList(),
                Brands = repoBrand.GetAll().Include(i => i.Products).ToList(),
                Products = repoProduct.GetAll().Include(i => i.Author).Include(i => i.Pictures).ToList()
            };
            ViewBag.PageTitle = "- Kategoriler";
            return View(allProductVM);
        }
    }
}
using BuySomeBook.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuySomeBook.WebUI.ViewModels
{
    public class AllProductVM
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
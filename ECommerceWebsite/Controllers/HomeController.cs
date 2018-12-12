using ECommerce.Services;
using ECommerceWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class HomeController : Controller
    {
        CategoriesService categoryService = new CategoriesService();

        public ActionResult Index()
        {
            // uncomment when HomeViewModel is created
            HomeViewModel model = new HomeViewModel();
            var FeaturedCategories = categoryService.GetFeaturedCategories();
            return View(model);
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
    }
}
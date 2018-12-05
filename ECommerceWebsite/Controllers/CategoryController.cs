﻿using ECommerce.Entities;
using ECommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class CategoryController : Controller
    {
         
        CategoriesService categoryService = new CategoriesService();
        // GET:
        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();
            // List<Category> cats = categoryService.GetCategories();
            return View(categories);
        }

        // CREATE GET:
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategory(category);
            return RedirectToAction("Index");
        } 
      
        ///////////////////////////////////////
        
        // EDIT GET:
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryService.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        //////////////////////////////////////////////

        // DELETE GET:
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoryService.GetCategory(ID);

            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            category = categoryService.GetCategory(category.ID);
            categoryService.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}
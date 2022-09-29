﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList() 
        {
            //var categoryvalues = cm.GetAllBL();
            return View();
        }
        [HttpGet]
        public ActionResult AddCategory() 
        {

            return View();
        
        }
        [HttpPost]
        public ActionResult AddCategory(Category p) 
        {
            //cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
    
}
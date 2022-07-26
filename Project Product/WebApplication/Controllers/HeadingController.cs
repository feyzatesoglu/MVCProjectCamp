﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm=new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {Text=x.CategoryName,
                                                  Value=x.CategoryID.ToString()

                                                  }).ToList();
            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text=x.WriterName + " "+x.WriterSurName,
                                                    Value=x.writerID.ToString()
                                                }).ToList();
            ViewBag.vlc=valueCategory;
            ViewBag.vlw = valueWriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAddBL(p);
            return RedirectToAction("Index");
        }
        public ActionResult ContentByHeading()
        {
            return View();
        }

    }
}
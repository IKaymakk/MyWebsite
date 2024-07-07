﻿using BusinessLaye.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class MyProjectsController : Controller
    {
        MyProjectsManager pm = new MyProjectsManager(new EfProjectsDal());
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ProjectList()
        {
            var projectlist = pm.ProjectList();
            return PartialView(projectlist);
        }
        public ActionResult ProjectDetails(int id)
        {
            var projectlist = pm.GetProject(id);
            return View(projectlist);
        }
    }
}
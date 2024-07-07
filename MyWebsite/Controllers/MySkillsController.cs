using BusinessLaye.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class MySkillsController : Controller
    {

        MySkillsManager msm = new MySkillsManager(new EfSkillsDal());
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult SkillList()
        {
            var skills_list = msm.SkillsList(); 
            return PartialView(skills_list);
        }
    }
}
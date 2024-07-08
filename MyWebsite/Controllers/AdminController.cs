using BusinessLaye.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class AdminController : Controller
    {
        MySkillsManager sm = new MySkillsManager(new EfSkillsDal());
        public ActionResult SkillsList()
        {
            var values = sm.SkillsList();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditSkills(int id)
        {
            var values = sm.GetSkill(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditSkills(MySkills myskills)
        {
            sm.UpdateSkill(myskills);
            return RedirectToAction("SkillsList");
        }
    }
}
using BusinessLaye.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyWebsite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        MySkillsManager sm = new MySkillsManager(new EfSkillsDal());
        MyServiceManager servicemanager = new MyServiceManager(new EfServiceDal());
        MyProjectsManager pm = new MyProjectsManager(new EfProjectsDal());

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
        public ActionResult ServicesList()
        {
            var values = servicemanager.ServicesList();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditService(int id)
        {
            var values = servicemanager.GetService(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditService(MyService p)
        {
            servicemanager.UpdateService(p);
            return RedirectToAction("ServicesList");
        }
        public ActionResult ProjectList()
        {
            var values = pm.ProjectList();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditProject(int id)
        {
            var values = pm.GetProject(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditProject(MyProjects p)
        {
            pm.UpdateProject(p);
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProject(MyProjects p)
        {
            pm.AddProject(p);
            return RedirectToAction("ProjectList");
        }
        public ActionResult DeleteProject(int id)
        {
            var x = pm.GetProject(id);
            pm.DeleteProject(x);
            return RedirectToAction("ProjectList");
        }
    }
}
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
    [AllowAnonymous]
    public class LoginController : Controller
    {
        AdminManager adminmanager = new AdminManager(new EFAdminDal());
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var admininfo = adminmanager.GetAdmin(p.AdminName, p.AdminPassword);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.AdminName, false);
                Session["AdminName"] = admininfo.AdminName;
                return RedirectToAction("Index", "ProjectList");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
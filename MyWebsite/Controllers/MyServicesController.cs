using BusinessLaye.Concrete;
using DataAccessLayer.EntityFramework;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class MyServicesController : Controller
    {
        MyServiceManager msm = new MyServiceManager(new EfServiceDal());
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ServicesList(int page = 1)
        {
            var services = msm.ServicesList().ToPagedList(1, 3);
            return PartialView(services);
        }
        public PartialViewResult ServicesList2(int page = 1)
        {
            var services = msm.ServicesList().ToPagedList(2, 3);
            return PartialView(services);
        }
    }
}
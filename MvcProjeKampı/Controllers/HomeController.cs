using BusinessLayer.Concrete;
using DataAccessLayer.EnitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class HomeController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            return View();
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
        [AllowAnonymous]
        public ActionResult HomePage()
        {
            return View();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }
        public PartialViewResult Navbar()
        {
            return PartialView();
        }

        public PartialViewResult Hero1()
        {
            var headingvalues = hm.GetList();
            return PartialView(headingvalues);
        }
        public PartialViewResult Hero2()
        {
            var headingvalues = hm.GetList();
            return PartialView(headingvalues);
        }
        public PartialViewResult Hero3()
        {
            var headingvalues = hm.GetList();
            return PartialView(headingvalues);
        }
        public PartialViewResult Hero4()
        {
            var headingvalues = hm.GetList();
            return PartialView(headingvalues);
        }
        public PartialViewResult Footer()
        {
            var headingvalues = hm.GetList();
            return PartialView(headingvalues);
        }


    }
}
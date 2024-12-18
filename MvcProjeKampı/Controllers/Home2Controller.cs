using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EnitiyFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class Home2Controller : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        HeadingManager Hm = new HeadingManager(new EfHeadingDal());

        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeroDetail(int id)
        {
            var headingvalue = Hm.GetList().FirstOrDefault(x => x.HeadingId == id); // ID'ye göre veri çek
            return PartialView(headingvalue); // View'e ilgili modeli gönder
        }

        public PartialViewResult Writer()
        {
            var values = wm.GetList();
            return PartialView(values);
        }
        public PartialViewResult Comments()
        {
            var values = cm.GetList();
            return PartialView(values);

        }
    }
}
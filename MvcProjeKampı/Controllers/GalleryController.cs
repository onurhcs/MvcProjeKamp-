using BusinessLayer.Concrete;
using DataAccessLayer.EnitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageManager ıfm = new ImageManager(new EfImageDal());

        public ActionResult Index()
        {
            var files = ıfm.GetList();
            return View(files);
        }
    }
}
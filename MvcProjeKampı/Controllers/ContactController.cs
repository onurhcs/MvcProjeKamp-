using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EnitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
        public ActionResult GetContactDetails(int id)
        {
            var values = cm.GetById(id);
            return View(values);
        }

        public PartialViewResult MessageListBox()
        {
            return PartialView();
        }
    }
}
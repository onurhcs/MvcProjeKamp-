using BusinessLayer.Concrete;
using DataAccessLayer.EnitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampı.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager cm = new MessageManager(new EfMessageDal());

        // GET: WriterPanelMessage
        public ActionResult Inbox()
        {
            var messagelist = cm.GetListInbox();
            return View(messagelist);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}
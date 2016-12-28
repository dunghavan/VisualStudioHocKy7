using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //ViewBag.myString = "Reus Hà Dũng";
            MessageModel obj = new MessageModel();
            obj.welcome = "Chào mừng đến với ASP.NET";
            obj.age = 22;
            return View(obj);
        }

    }
}

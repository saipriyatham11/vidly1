using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Latest()
        {
            var news = new News() { Name = "Shrek!" };
           //return View(news);
            return RedirectToAction("Index", "Home");
        }
    }
}
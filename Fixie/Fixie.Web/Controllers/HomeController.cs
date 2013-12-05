using Fixie.Infrastructure;
using Fixie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fixie.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var repo = new BoardRepository(new FixieContext());
            var boards = repo.FindAll();

            return View();
        }
    }
}

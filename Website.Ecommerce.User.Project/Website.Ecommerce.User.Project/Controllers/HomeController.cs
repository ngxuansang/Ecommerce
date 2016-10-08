using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Ecommerce.User.Project.Ecommerce.Models;

namespace Website.Ecommerce.User.Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            return View(model);
        }
    }
}
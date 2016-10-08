using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Ecommerce.User.Project.Ecommerce.Models;

namespace Website.Ecommerce.User.Project.Controllers
{
    public class CategorieDetailController : Controller
    {
        // GET: CategorieDetail
        public ActionResult GetCategorie(int id)
        {
            CategorieDetail model = new CategorieDetail(id);
            return View(model);
        }
    }
}
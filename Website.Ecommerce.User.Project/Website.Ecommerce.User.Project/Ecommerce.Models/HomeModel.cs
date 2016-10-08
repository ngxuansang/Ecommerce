using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Ecommerce.User.Project.Models;

namespace Website.Ecommerce.User.Project.Ecommerce.Models
{
    public class HomeModel
    {
        private EcommerceEntities db { get; set; }

        public HomeModel()
        {
            db = new EcommerceEntities();
        }
    }
}
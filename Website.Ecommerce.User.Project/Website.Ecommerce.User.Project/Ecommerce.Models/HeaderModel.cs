using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Ecommerce.User.Project.Models;

namespace Website.Ecommerce.User.Project.Ecommerce.Models
{
    public class HeaderModel
    {
        public List<CATEGORIE> VerticalCategories { get; set; }
        public List<CATEGORIE> HorizontalCategories { get; set; }
        public HeaderModel()
        {
            EcommerceEntities db = new EcommerceEntities();
            this.HorizontalCategories = db.CATEGORIEs.Where(x => x.CATEGORIE_TYPE == 2 && x.CATEGORIE_ROOT == null).ToList();
            this.VerticalCategories = db.CATEGORIEs.Where(x => x.CATEGORIE_TYPE == 1 && x.CATEGORIE_ROOT == null).ToList();
        }
    }
}
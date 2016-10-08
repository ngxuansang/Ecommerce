using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Ecommerce.User.Project.Models;

namespace Website.Ecommerce.User.Project.Ecommerce.Models
{
    public class CategorieDetail
    {
        private EcommerceEntities db = null;
        public List<CATEGORIE> Categories { get; set; }
        public CATEGORIE CategorieCurrent { get; set; }
        public CATEGORIE CategorieRoot { get; set; }

        public CategorieDetail()
        {
            this.Categories = new List<CATEGORIE>();
            this.CategorieCurrent = new CATEGORIE();
        }

        public CategorieDetail(int categorie_id)
        {
            db = new EcommerceEntities();
            Categories = new List<CATEGORIE>();
            CategorieCurrent = db.CATEGORIEs.First(x => x.CATEGORIE_ID == categorie_id);
            CATEGORIE root = new CATEGORIE();
            #region TimRootCategorie
            root = CategorieCurrent;
            while (root.CATEGORIE_ROOT != null)
            {
                root = root.CATEGORIE2;
            }
            CategorieRoot = root;
            #endregion
            Categories = root.CATEGORIE1.ToList();
        }
    }
}
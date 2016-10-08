//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.Ecommerce.User.Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT_DETAIL()
        {
            this.ORDER_TBL = new HashSet<ORDER_TBL>();
            this.CATEGORIEs = new HashSet<CATEGORIE>();
            this.PAY_METHOD = new HashSet<PAY_METHOD>();
            this.SALE_PROMOTION_EVENT = new HashSet<SALE_PROMOTION_EVENT>();
            this.SIZE_TYPE = new HashSet<SIZE_TYPE>();
            this.CUSTOMERs = new HashSet<CUSTOMER>();
        }
    
        public long PRODUCT_ID { get; set; }
        public string PRODUCT_TITLE { get; set; }
        public string PRODUCT_TITLE_UNSIGNED { get; set; }
        public string PRODUCT_CODE { get; set; }
        public Nullable<long> PRODUCT_PRICE { get; set; }
        public Nullable<long> PRODUCT_SPECIAL_PRICE { get; set; }
        public string PRODUCT_DESCIPTION { get; set; }
        public string PRODUCT_INFOMATION { get; set; }
        public Nullable<bool> PRODUCT_AVAILABILITY { get; set; }
        public Nullable<int> PRODUCT_CONDITION { get; set; }
        public string PRODUCT_SKU { get; set; }
        public Nullable<long> PRODUCT_BARCODE { get; set; }
        public Nullable<long> PRODUCT_QUANTITY { get; set; }
        public Nullable<System.DateTime> PRODUCT_ADD_DATE { get; set; }
        public Nullable<long> BRAND_PRODUCT_ID { get; set; }
    
        public virtual BRAND BRAND { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_TBL> ORDER_TBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORIE> CATEGORIEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAY_METHOD> PAY_METHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALE_PROMOTION_EVENT> SALE_PROMOTION_EVENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIZE_TYPE> SIZE_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMERs { get; set; }
    }
}

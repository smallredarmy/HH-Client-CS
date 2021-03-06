//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANY()
        {
            this.BILL_DETAIL = new HashSet<BILL_DETAIL>();
            this.BILL_HEADER = new HashSet<BILL_HEADER>();
            this.CHECKBILL_DETAIL = new HashSet<CHECKBILL_DETAIL>();
            this.CHECKBILL_HEADER = new HashSet<CHECKBILL_HEADER>();
            this.ITEM = new HashSet<ITEM>();
            this.ITEM_ZONE_CAPACITY = new HashSet<ITEM_ZONE_CAPACITY>();
            this.STOCKTAKINGBILL_DETAIL = new HashSet<STOCKTAKINGBILL_DETAIL>();
            this.STOCKTAKINGBILL_HEADER = new HashSet<STOCKTAKINGBILL_HEADER>();
            this.SUPPLIERCUSTOMER = new HashSet<SUPPLIERCUSTOMER>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public int WAREHOUSEID { get; set; }
        public string NAME { get; set; }
        public string ATTENTIONTO { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string DISTRICT { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string POSTALCODE { get; set; }
        public string PHONENUM { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string SHIPMENTPREFIX { get; set; }
        public string RECEIPTPREFIX { get; set; }
        public string NAMEEN { get; set; }
        public string USERDEF1 { get; set; }
        public string USERDEF2 { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL_DETAIL> BILL_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL_HEADER> BILL_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECKBILL_DETAIL> CHECKBILL_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECKBILL_HEADER> CHECKBILL_HEADER { get; set; }
        public virtual WAREHOUSE WAREHOUSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM> ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_ZONE_CAPACITY> ITEM_ZONE_CAPACITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCKTAKINGBILL_DETAIL> STOCKTAKINGBILL_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCKTAKINGBILL_HEADER> STOCKTAKINGBILL_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIERCUSTOMER> SUPPLIERCUSTOMER { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WMS_TaskDtl
    {
        public int IsId { get; set; }
        public int Task_Id { get; set; }
        public string TaskDtl_PalletId { get; set; }
        public string TaskDtl_InteractNum { get; set; }
        public string TaskDtl_MaterialCode { get; set; }
        public string TaskDtl_MaterialName { get; set; }
        public string TaskDtl_MaterialBarcode { get; set; }
        public Nullable<int> TaskDtl_MaterialQty { get; set; }
        public Nullable<int> TaskDtl_WorkStatus { get; set; }
        public string Bill_BillNo { get; set; }
        public Nullable<int> Bill_BillItem { get; set; }
        public string Bill_BillType { get; set; }
        public string Bill_LinkNo { get; set; }
        public Nullable<int> Bill_LinkItem { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}

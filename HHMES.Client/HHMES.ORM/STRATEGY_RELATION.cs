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
    
    public partial class STRATEGY_RELATION
    {
        public int ID { get; set; }
        public int STRATEGY_HEADERID { get; set; }
        public int STRATEGY_DETAILID { get; set; }
        public int SEQUENCE { get; set; }
        public bool ENABLE { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        public virtual STRATEGY_DETAIL STRATEGY_DETAIL { get; set; }
        public virtual STRATEGY_HEADER STRATEGY_HEADER { get; set; }
    }
}

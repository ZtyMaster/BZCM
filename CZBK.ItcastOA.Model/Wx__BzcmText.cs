//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CZBK.ItcastOA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wx__BzcmText
    {
        public long ID { get; set; }
        public string Str_Text { get; set; }
        public Nullable<long> BzcmText_FanChan_ID { get; set; }
        public int DEL { get; set; }
        public long WXuserID { get; set; }
        public System.DateTime AltTime { get; set; }
        public double AltPhoto { get; set; }
    
        public virtual BzcmText_FanChan BzcmText_FanChan { get; set; }
        public virtual WXXUserInfo WXXUserInfo { get; set; }
    }
}
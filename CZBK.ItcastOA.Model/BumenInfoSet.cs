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
    
    public partial class BumenInfoSet
    {
        public BumenInfoSet()
        {
            this.UserInfoes = new HashSet<UserInfo>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Gushu { get; set; }
        public string Renark { get; set; }
        public System.DateTime SubTime { get; set; }
        public short DelFlag { get; set; }
    
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}

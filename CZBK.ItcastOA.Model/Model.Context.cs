﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BZCMEntities : DbContext
    {
        public BZCMEntities()
            : base("name=BZCMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActionInfo> ActionInfoes { get; set; }
        public DbSet<BumenInfoSet> BumenInfoSets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Login_list> Login_list { get; set; }
        public DbSet<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }
        public DbSet<RoleInfo> RoleInfoes { get; set; }
        public DbSet<T_BoolItem> T_BoolItem { get; set; }
        public DbSet<Userbak> Userbaks { get; set; }
        public DbSet<UserInfo> UserInfoes { get; set; }
        public DbSet<WXX_FormID> WXX_FormID { get; set; }
        public DbSet<WXXMenuInfo> WXXMenuInfoes { get; set; }
        public DbSet<WXXUserInfo> WXXUserInfoes { get; set; }
        public DbSet<BzcmText_FanChan> BzcmText_FanChan { get; set; }
        public DbSet<IsFristItem> IsFristItems { get; set; }
        public DbSet<Wx__BzcmText> Wx__BzcmText { get; set; }
        public DbSet<WXXLogin_bak> WXXLogin_bak { get; set; }
    }
}

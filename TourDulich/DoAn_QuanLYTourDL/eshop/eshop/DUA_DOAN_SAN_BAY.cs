//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eshop
{
    using System;
    using System.Collections.Generic;
    
    public partial class DUA_DOAN_SAN_BAY
    {
        public string MaSB { get; set; }
        public string TuDiaDiem { get; set; }
        public string DenDiaDiem { get; set; }
        public Nullable<System.DateTime> NgayDon { get; set; }
        public string GioDoan { get; set; }
        public string MaKH { get; set; }
        public Nullable<int> tongtien { get; set; }
    
        public virtual SAN_BAY SAN_BAY { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
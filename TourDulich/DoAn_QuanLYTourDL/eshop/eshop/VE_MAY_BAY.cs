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
    
    public partial class VE_MAY_BAY
    {
        public string MaVe { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiemKhoiHanh { get; set; }
        public string DiemDen { get; set; }
        public Nullable<System.DateTime> NgayDi { get; set; }
        public Nullable<System.DateTime> NgayVe { get; set; }
        public Nullable<int> SoHanhKhach { get; set; }
        public string HangGhe { get; set; }
        public Nullable<int> Tongtien { get; set; }
    
        public virtual CHITIET_CHUYENBAY CHITIET_CHUYENBAY { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}

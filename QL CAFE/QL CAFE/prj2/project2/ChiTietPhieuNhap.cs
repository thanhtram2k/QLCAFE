//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhap
    {
        public string Mapn { get; set; }
        public string Masp { get; set; }
        public string Tensp { get; set; }
        public Nullable<double> Dongia { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<double> Thanhtien { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}

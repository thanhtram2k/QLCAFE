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
    
    public partial class PhieuXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuat()
        {
            this.ChiTietPhieuXuats = new HashSet<ChiTietPhieuXuat>();
        }

        public PhieuXuat(string mapx, string manvxuat, string banso)
        {
            Mapx = mapx;
            Manvxuat = manvxuat;
            Banso = banso;
        }

        public string Mapx { get; set; }
        public string Manvxuat { get; set; }
        public Nullable<System.DateTime> Ngayxuat { get; set; }
        public string Banso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}

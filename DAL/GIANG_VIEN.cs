//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIANG_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIANG_VIEN()
        {
            this.BAI_KIEM_TRA = new HashSet<BAI_KIEM_TRA>();
            this.LOP_HOC_PHAN = new HashSet<LOP_HOC_PHAN>();
            this.LOP_SINH_HOAT = new HashSet<LOP_SINH_HOAT>();
            this.THONG_BAO = new HashSet<THONG_BAO>();
        }
    
        public string MaGV { get; set; }
        public string TrinhDo { get; set; }
        public Nullable<int> Luong { get; set; }
        public string MaKhoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAI_KIEM_TRA> BAI_KIEM_TRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOC_PHAN> LOP_HOC_PHAN { get; set; }
        public virtual NGUOI_DUNG NGUOI_DUNG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_SINH_HOAT> LOP_SINH_HOAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONG_BAO> THONG_BAO { get; set; }
        public virtual KHOA KHOA { get; set; }
    }
}
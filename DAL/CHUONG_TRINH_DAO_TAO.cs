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
    
    public partial class CHUONG_TRINH_DAO_TAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUONG_TRINH_DAO_TAO()
        {
            this.SINH_VIEN = new HashSet<SINH_VIEN>();
        }
    
        public string MaCTDT { get; set; }
        public string TenCTDT { get; set; }
        public string MaKhoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINH_VIEN> SINH_VIEN { get; set; }
        public virtual KHOA KHOA { get; set; }
    }
}

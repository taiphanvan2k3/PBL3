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
    
    public partial class THONGBAO_LOPHOCPHAN
    {
        public int MaTB { get; set; }
        public string MaLopHP { get; set; }
        public string MoTa { get; set; }
    
        public virtual LOP_HOC_PHAN LOP_HOC_PHAN { get; set; }
        public virtual THONG_BAO THONG_BAO { get; set; }
    }
}

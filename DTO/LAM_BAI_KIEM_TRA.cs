//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LAM_BAI_KIEM_TRA
    {
        public string MaSV { get; set; }
        public int MaBaiKiemTra { get; set; }
        public string MaLopHP { get; set; }
        public byte ThoiGianNopBai { get; set; }
        public byte SoCauDung { get; set; }
        public byte SoLanViPham { get; set; }
        public double Diem { get; set; }
    
        public virtual BAI_KIEM_TRA BAI_KIEM_TRA { get; set; }
        public virtual LOP_HOC_PHAN LOP_HOC_PHAN { get; set; }
        public virtual SINH_VIEN SINH_VIEN { get; set; }
    }
}
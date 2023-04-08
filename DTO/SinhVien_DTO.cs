using System;
using System.Runtime.Remoting.Channels;

namespace DTO
{
    public class SinhVien_DTO : NguoiDung_DTO
    {
        public string MaCTDT { get; set; }
        public string MaLopSH { get; set; }
        public string TenCTDT { get; set; }
        public string Khoa { get; set; }
        public SinhVien_DTO(){}
    }
}

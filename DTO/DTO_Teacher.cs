using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Teacher
    {
        public string MaGV { get; set; }
        public string HoGV { get; set; }
        public string TenGV { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDo { get; set; }
        public string EmailCaNhan { get; set; }
        public int Luong { get; set; }
        public string Sdt { get; set; }
        public string MaKhoa { get; set; }


        public DTO_Teacher() { }
        public DTO_Teacher(string maGV, string hoGV, string tenGV, DateTime ngaySinh, string gioiTinh, string diaChi, string trinhDo, string emailCaNhan, int luong, string sdt, string maKhoa)
        {
            MaGV = maGV;
            HoGV = hoGV;
            TenGV = tenGV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            TrinhDo = trinhDo;
            EmailCaNhan = emailCaNhan;
            Luong = luong;
            Sdt = sdt;
            MaKhoa = maKhoa;
        }
    }
}

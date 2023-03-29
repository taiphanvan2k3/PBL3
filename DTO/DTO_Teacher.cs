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
        public string Ho { get; set; }
        public string Ten { get; set; }
        public byte[] AnhCaNhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string EmailCaNhan { get; set; }
        public string Sdt { get; set; }
        public string TrinhDo { get; set; }
        public int Luong { get; set; }
        public string MaKhoa { get; set; }


        public DTO_Teacher() { }
        public DTO_Teacher(string maGV, string ho, string ten, byte[] anhCaNhan, DateTime ngaySinh, string gioiTinh, string diaChi, string emailCaNhan, string sdt, string trinhDo, int luong, string maKhoa)
        {
            MaGV = maGV;
            Ho = ho;
            Ten = ten;
            AnhCaNhan = anhCaNhan;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            EmailCaNhan = emailCaNhan;
            Sdt = sdt;
            TrinhDo = trinhDo;
            Luong = luong;
            MaKhoa = maKhoa;
        }
    }
}

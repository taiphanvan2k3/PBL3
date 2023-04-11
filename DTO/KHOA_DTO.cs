using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHOA_DTO
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public KHOA_DTO() { }

        public KHOA_DTO(string maKhoa, string tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }
    }
}

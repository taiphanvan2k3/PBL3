using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHUONG_TRINH_DAO_TAO_DTO
    {

        public string MaCTDT { get; set; }
        public string TenCTDT { get; set; }
        public string MaKhoa { get; set; }

        public CHUONG_TRINH_DAO_TAO_DTO() { }
        public CHUONG_TRINH_DAO_TAO_DTO(string maCTDT, string tenCTDT, string maKhoa)
        {
            MaCTDT = maCTDT;
            TenCTDT = tenCTDT;
            MaKhoa = maKhoa;
        }


    }
}

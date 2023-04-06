using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THONG_TIN_DANG_NHAP_DTO
    {
        public string TaiKhoan { get; set; }
        public string MkUngDung { get; set; }
        public string VaiTro { get; set; }
        public string MaXacThucDeLayLaiMK { get; set; }

        public THONG_TIN_DANG_NHAP_DTO() { }
        public THONG_TIN_DANG_NHAP_DTO(string taiKhoan, string mkUngDung, string vaiTro, string maXacThucDeLayLaiMK)
        {
            TaiKhoan = taiKhoan;
            MkUngDung = mkUngDung;
            VaiTro = vaiTro;
            MaXacThucDeLayLaiMK = maXacThucDeLayLaiMK;
        }


    }
}

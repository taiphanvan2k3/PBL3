using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformationAcc_DTO
    {
        [DisplayName ("Tài khoản")]
        public string TaiKhoan { get; set; }
        [DisplayName("Vai trò")]
        public string VaiTro { get; set; }
        [DisplayName("CCCD")]
        public string MaCCCD { get; set; }
        [DisplayName("Họ và tên")]
        public string Ten { get; set; }
        [DisplayName("Email")]
        public string EmailTruongCap { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [DisplayName("Giới tính")]
        public bool GioiTinh { get; set; }
        [DisplayName("Mã Khoa")]
        public string MaKhoa { get; set; }





    }
}

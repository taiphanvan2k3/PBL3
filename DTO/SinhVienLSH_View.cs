﻿using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Lớp này tạo ra mục đích để hiển thị thông tin lên datagridview xem thông tin lớp sinh hoạt
    /// </summary>
    public class SinhVienLSH_View
    {
        public int STT { get; set; }

        [DisplayName("Số thẻ sinh viên")]
        public string MaSV { get; set; }

        [DisplayName("Họ tên sinh viên")]
        public string HoTen { get; set; }

        [DisplayName("Điện thoại")]
        public string SDT { get; set; }

        [DisplayName("Email cá nhân")]
        public string EmailCaNhan { get; set; }

        [DisplayName("Điện thoại người thân")]
        public string SdtNguoiThan { get; set; }
    }
}

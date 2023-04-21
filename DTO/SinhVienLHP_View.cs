using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Hiển thị danh sách sinh viên lên datagridview của phần xem sinh viên lớp học phần
    /// </summary>
    public class SinhVienLHP_View
    {
        [DisplayName("STT")]
        public int STT { get; set; }

        [DisplayName("Mã sinh viên")]
        public string MSSV { get; set; }

        [DisplayName("Họ tên sinh viên")]
        public string HoTenSV { get; set; }

        [DisplayName("Lớp sinh hoạt")]
        public string LopSH { get; set; }

        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }
    }
}

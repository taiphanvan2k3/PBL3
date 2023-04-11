using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocPhan_DTO
    {
        public int STT { get; set; }

        [DisplayName("Mã học phần")]               
        public string MaHP { get; set; }

        [DisplayName("Tên học phần")]
        public string TenHP { get; set; }

        [DisplayName("Số tín chỉ")]
        public int SoTC { get; set; }

        [DisplayName("Giảng viên")]
        public string TenGV { get; set; }


        [DisplayName("Thời khoá biểu")]
        public ThoiKhoaBieu_DTO tkb { get; set; }

    }
}

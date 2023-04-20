using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc_DTO
    {
        [DisplayName("Mã môn học")]
        public string MaMH { get; set; }

        [DisplayName("Tên môn học")]
        public string TenMH { get; set; }


        [DisplayName("Số tín chỉ")]
        public int SoTC { get; set; }

        [DisplayName("Công thức tính điểm")]
        public string CtTinhDiem { get; set; }

        [Browsable(false)]
        public string MaKhoa { get; set; }
    }
}

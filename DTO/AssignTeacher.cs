using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AssignTeacher
    {

        [DisplayName("Mã giảng viên")]
        public string MaGV { get; set; }

        [DisplayName("Tên giảng viên")]

        public string TenGV { get; set; }

        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }

        [DisplayName("Số lượng HP phụ trách")]
        public int SoLuongHPPhuTrach { get; set; }
    }
}

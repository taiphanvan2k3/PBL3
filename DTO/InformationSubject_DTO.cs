using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformationSubject_DTO
    {
        [DisplayName("Mã môn học")]
        public string MaMh { get; set; }
        [DisplayName("Tên môn học")]
        public string TenMh { get; set; }
        [DisplayName("Số tín chỉ")]
        public int SoTC { get; set; }
        [DisplayName("Khoa")]
        public string TenKhoa { get; set; }
    }
}

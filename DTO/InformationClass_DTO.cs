using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformationClass_DTO
    {
        [DisplayName("Mã lớp")]
        public string maLop { get; set; }
        [DisplayName("Tên lớp")]
        public string tenLop { get; set; }
        [DisplayName("Mã GV")]
        public string maGV { get; set; }
        [DisplayName("Họ và tên")]
        public string hoTenGV { get; set; }
        [DisplayName("Số lượng sinh viên")]
        public int soLuongSV { get; set; }
        [DisplayName("Số lượng tối đa")]
        public int soLuongToiDa { get; set; }
        
    }
}

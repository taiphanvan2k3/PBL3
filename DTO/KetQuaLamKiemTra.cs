using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KetQuaLamKiemTra
    {
        [DisplayName("Mã học phần")]
        public string MaHP { get; set; }

        [DisplayName("Tên môn học")]
        public string TenMH { get; set; }

        [DisplayName("Loại bài")] //BT,GK,CK
        public string LoaiBaiKiemTra { get; set; }

        [DisplayName("Điểm số")]
        public double Diem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Lớp này dùng để lưu kết quả làm bài của các sinh viên khi làm một bài kiểm tra nào đó
    /// </summary>
    public class KetQuaLamKiemTra_SVLHP
    {
        [DisplayName("Mã sinh viên")]
        public string MaSV { get; set; }

        [DisplayName("Tên sinh viên")]
        public string HoTenSV { get; set; }

        [DisplayName("Lớp sinh hoạt")]        
        public string LopSH { get; set; }

        [DisplayName("Thời gian làm bài")]
        public DateTime ThoiGianLamBai { get; set; }

        [DisplayName("Thời gian nộp bài")]
        public DateTime ThoiGianNopBai { get; set; }

        [DisplayName("Số câu đúng")]
        public int SoCauDung { get; set; }

        [DisplayName("Số lần vi phạm")]
        public int SoLanViPham { get; set; }

        [DisplayName("Điểm số")]
        public double Diem { get; set; }
    }
}

using System;
using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Hiển thị kết quả làm bài của các sinh viên trong một lớp học phần nào đó, giảng viên sẽ có
    /// giao diện để xem kết quả làm bài của các sinh viên tại 1 bài kiểm tra nào đó do mình tạo ra
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

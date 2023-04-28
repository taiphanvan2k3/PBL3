using System;
using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Dùng để lưu kết quả làm bài kiểm tra của 1 sinh viên ở lớp học phần nào đó
    /// </summary>
    public class KetQuaLamKiemTra
    {
        [DisplayName("Mã học phần")]
        public string MaHP { get; set; }

        [DisplayName("Tên môn học")]
        public string TenMH { get; set; }

        [DisplayName("Tên bài kiểm tra")]
        public string TenBaiKiemTra { get; set; }

        [DisplayName("Kì học")]
        public int KiHoc { get; set; }

        [DisplayName("Năm học")]
        public string NamHoc { get; set; }

        [DisplayName("Thời gian làm bài")]
        public DateTime ThoiGianLamBai { get; set; }

        [DisplayName("Thời gian nộp bài")]
        public DateTime ThoiGianNopBai { get; set; }

        [DisplayName("Tổng số câu")]
        public int TongSoCau { get; set; }

        [DisplayName("Số câu đúng")]
        public int SoCauDung { get; set; }

        [DisplayName("Điểm số")]
        public double Diem { get; set; }

        [DisplayName("Số lần vi phạm")]
        public int SoLanViPham { get; set; }
    }
}

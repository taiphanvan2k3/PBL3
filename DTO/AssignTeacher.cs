using System.ComponentModel;

namespace DTO
{
    public class AssignTeacher
    {
        [DisplayName("STT")]
        public int STT { get; set; }
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

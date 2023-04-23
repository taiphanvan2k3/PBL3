using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Lớp này được coi là DTO trả dữ liệu từ DAL về cho frmViewDetailModuleClass, cũng như dùng
    /// để cập nhật dữ liệu ở frmViewDetailModuleClass
    /// </summary>
    public class LopHocPhan_AdminEdit
    {
        public string MaMH { get; set; }
        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public int SoTc { get; set; }
        public int KiHoc { get; set; }
        public int NamHoc { get; set; }
        public string MaGV { get; set; }
        public string HoTenGV { get; set; }
        public string Thu { get; set; }
        public int? TietBD { get; set; }
        public int? TietKT { get; set; }
        public string MaPhong { get; set; }
        public int SoLuongMax { get; set; }
    }
}

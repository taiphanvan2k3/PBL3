using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Lớp này được coi là DTO trả dữ liệu từ DAL về cho frmViewDetailHomeroomClass, cũng như dùng
    /// để cập nhật dữ liệu ở frmViewDetailHomeroomClass
    /// </summary>
    public class LopSinhHoat_AdminEdit
    {
        public string MaLopSH { get; set; }
        public string TenKhoa { get; set; }
        public string MaGVCN { get; set; }
        public string TenGVCN { get; set; }
        public int? SoLuongToiDa { get; set; }
    }
}

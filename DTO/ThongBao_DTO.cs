using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongBao_DTO
    {
        public DateTime NgayTao { get; set; }
        public string TenGV { get; set; }
        
        //Kiểm tra người nhắn là thầy hay cô
        public string CheckGender { get; set; }
        public string MaLopHP { get; set; }
        public string TenMonHoc { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }

        // Lưu trữ page mà thông báo này sẽ hiển thị
        public int AtPage { get; set; }
    }
}

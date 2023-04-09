using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien_DTO : NguoiDung_DTO
    {
        public string TrinhDo { get; set; }
        public int? Luong { get; set; }
        public string Khoa { get; set; }
        public GiangVien_DTO() { }
    }
}

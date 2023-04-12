using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocPhan_AdminEdit
    {
        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public int SoTc { get; set; }
        public string MaGV { get; set; }
        public string HoTenGV { get; set; }
        public string Thu { get; set; }
        public int? TietBD { get; set; }
        public int? TietKT { get; set; }
        public string MaPhong { get; set; }
    }
}

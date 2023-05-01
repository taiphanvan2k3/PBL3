using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Lưu thông tin kết quả học tập của 1 môn học phần nào đó của sinh viên
    /// </summary>
    public class KetQuaHocTap
    {
        public int STT { get; set; }

        [DisplayName("Mã học phần")]
        public string MaLopHP { get; set; }

        [DisplayName("Tên môn học")]
        public string TenMH { get; set; }

        [DisplayName("Số tín chỉ")]
        public int SoTC { get; set; }

        [DisplayName("Công thức điểm")]
        public string CtTinhDiem { get; set; }

        [DisplayName("Kì học")]
        public int KiHoc { get; set; }

        [DisplayName("Năm học")]
        public string NamHoc { get; set; } //vd 2022 - 2023

        public List<double> DiemBTs = new List<double>();

        [DisplayName("Bài tập")]
        public string BT
        {
            get
            {
                string res = "";
                for (int i = 0; i < DiemBTs.Count; i++)
                {
                    res += DiemBTs[i];
                    if (i < DiemBTs.Count - 1)
                        res += "; ";
                }
                return res;
            }
        }

        [DisplayName("Giữa kì")]
        public double? GK { get; set; }

        [DisplayName("Cuối kì")]
        public double? CK { get; set; }

        [DisplayName("Quá trình")]
        public double? QT { get; set; }

        [DisplayName("Đồ án")]
        public double? DA { get; set; }

        [DisplayName("Điểm trung bình")]
        public double? DTB
        {
            get
            {
                if (DiemBTs.Count > 0 && GK != null && CK != null)
                {
                    double diemBT = 0;
                    foreach (double diem in DiemBTs)
                        diemBT += diem;
                    diemBT /= DiemBTs.Count;
                    List<int> CongThuc = ToListIntCongThucTinhDiem(CtTinhDiem);
                    return (diemBT * CongThuc[0] + ((double)GK) * CongThuc[1] + ((double)CK) * CongThuc[2]) / 10;
                }
                else if (QT != null && DA != null)
                {
                    List<int> CongThuc = ToListIntCongThucTinhDiem(CtTinhDiem);
                    return (QT * CongThuc[0] + DA * CongThuc[1]) / 10;
                }
                return null;
            }
        }

        private List<int> ToListIntCongThucTinhDiem(string CtTinhDiem)
        {
            string[] tmp = CtTinhDiem.Split('-');
            List<int> res = new List<int>();
            foreach (string str in tmp)
                res.Add(Convert.ToInt32(str));
            return res;
        }
    }
}

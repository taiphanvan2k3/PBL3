using System;
using System.Collections.Generic;

namespace DTO
{
    public class CauHoi_DTO
    {
        public string TenCauHoi { get; set; }
        public bool Checked { get; set; } = false;
        public List<string> DapAnHienThi;

        private List<string> DapAnDung;

        public List<int> IndexSelection = new List<int>();
        public bool IsSingleQuestion { get; set; }

        public CauHoi_DTO(string TenCauHoi, string DapAnA, string DapAnB, string DapAnC, string DapAnD,
                          string MaDapAnDung)
        {
            this.TenCauHoi = TenCauHoi;

            DapAnHienThi = new List<string>
            {
                DapAnA,
                DapAnB,
                DapAnC,
                DapAnD
            };
            IsSingleQuestion = MaDapAnDung.Length == 1;

            //Thực hiện việc xác định đáp án đúng trước khi xoá trộn mảng hiển thị
            DapAnDung = new List<string>();

            //Mã 
            SplitMaDapAnDung(MaDapAnDung);
            ShuffleDapAnHienThi();
        }
        private void SplitMaDapAnDung(string MaDapAnDung)
        {
            //Vd mã đáp án đúng là 'ACD' -> có 3 câu đúng
            foreach (char c in MaDapAnDung)
            {
                int idx = char.ToUpper(c) - 'A';
                DapAnDung.Add(DapAnHienThi[idx]);
            }
        }

        public void ShuffleDapAnHienThi()
        {
            //Mỗi lần khởi tạo đối tượng Random này thì tạo ra 1 GUID mới (128 bit), sau đó băm giá trị này
            //để gán cho giá trị seed trong Random. Do đó sẽ tránh việc lặp lại bộ số ngẫu nhiên
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int n = DapAnHienThi.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = r.Next(i + 1);
                string tmp = DapAnHienThi[i];
                DapAnHienThi[i] = DapAnHienThi[j];
                DapAnHienThi[j] = tmp;
            }
        }

        public bool CheckCorrectAnswer()
        {
            List<string> DapAnChon = new List<string>();
            foreach (int idx in IndexSelection)
                DapAnChon.Add(DapAnHienThi[idx]);

            if (DapAnChon.Count != DapAnDung.Count)
                return false;

            //Do đáp án hiển thị bị xoá trộn lên nên giờ để check được làm đúng hay sai
            //phải sort 2 mảng này rồi so sánh
            DapAnChon.Sort();
            DapAnDung.Sort();

            for (int i = 0; i < DapAnDung.Count; i++)
            {
                if (DapAnChon[i] != DapAnDung[i])
                    return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;

namespace DTO
{
    public class CauHoi_DTO
    {
        public string TenCauHoi { get; set; }
        public List<string> DapAnHienThi;

        private List<string> DapAnDung;

        //
        private List<string> DapAnChon;
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

        private void ShuffleDapAnHienThi()
        {
            Random r = new Random();
            int n = DapAnHienThi.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = r.Next(i + 1);
                string tmp= DapAnHienThi[i];
                DapAnHienThi[i] = DapAnHienThi[j];
                DapAnHienThi[j] = tmp;
            }
        }

        public bool CheckCorrectAnswer(List<string> DapAnChon)
        {
            DapAnChon.Sort();
            DapAnDung.Sort();
            for(int i = 0; i < DapAnChon.Count; i++)
            {
                if (DapAnChon[i] != DapAnDung[i])
                    return false;
            }
            return true;
        }
    }
}

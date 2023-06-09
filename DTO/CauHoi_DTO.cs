using System;
using System.Collections.Generic;

namespace DTO
{
    public class CauHoi_DTO
    {
        public string TenCauHoi { get; set; }
        public bool Checked { get; set; } = false;

        //List này sẽ lưu các chuỗi đáp án sau khi đã xáo trộn ABCD và dùng để hiển thị lên giao diện 
        public List<string> DapAnHienThi;

        private List<string> DapAnDung;

        //Lưu lại chỉ số của các đáp án đã chọn
        public List<int> IndexSelection = new List<int>();
        public bool IsSingleQuestion { get; set; }

        #region edit 9/6/2023
        private bool[] indexCorrectAnswer = new bool[] { false, false, false, false };
        private string maDapAnDung = "";
        private string maDapAnChon = "";
        #endregion

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

            //VD mã đáp án đúng của câu hỏi này lưu trong CSDL là ACD thì đáp án đúng
            //của nó là các câu hỏi ở index 0,2,3.
            SplitMaDapAnDung(MaDapAnDung);
            ShuffleDapAnHienThi();
        }

        private void SplitMaDapAnDung(string MaDapAnDung)
        {
            //Vd mã đáp án đúng là 'ACD' -> có 3 câu đúng
            foreach (char c in MaDapAnDung)
            {
                int idx = char.ToUpper(c) - 'A';
                indexCorrectAnswer[idx] = true;
                //Lưu lại đáp án đúng dưới dạng string để lát so sánh với đáp án người dùng chọn
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

                // Khi xáo trộn đáp án hiển thị thì đồng thời phải xáo trộn đáp án đúng
                bool temp = indexCorrectAnswer[i];
                indexCorrectAnswer[i] = indexCorrectAnswer[j];
                indexCorrectAnswer[j] = temp;
            }

            for (int i = 0; i < indexCorrectAnswer.Length; i++)
            {
                if (indexCorrectAnswer[i])
                    maDapAnDung += ('A' + i);
            }
        }

        public bool CheckCorrectAnswer()
        {
            //List<string> DapAnChon = new List<string>();
            //foreach (int idx in IndexSelection)
            //{
            //    DapAnChon.Add(DapAnHienThi[idx]);
            //    _indexSelectionAnswer += ('a' + idx);
            //}

            //if (DapAnChon.Count != DapAnDung.Count)
            //    return false;

            ////Do đáp án hiển thị bị xoá trộn lên nên giờ để check được làm đúng hay sai
            ////phải sort 2 mảng này rồi so sánh
            //DapAnChon.Sort();
            //DapAnDung.Sort();

            //for (int i = 0; i < DapAnDung.Count; i++)
            //{
            //    if (DapAnChon[i] != DapAnDung[i])
            //        return false;
            //}
            //return true;
            foreach(int idx in IndexSelection)
                maDapAnChon += ('A' + idx);
            return maDapAnDung == maDapAnChon;
        }
    }
}

using BLL;
using DTO;
using GUI.MyCustomControl;
using GUI.MyUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhucKhao : Form
    {
        public frmPhucKhao()
        {
            InitializeComponent();
        }

        public int MaBaiKiemTra { get; set; }
        public string TenBaiKiemTra
        {
            set => lbTenBaiKiemTra.Text = value;
        }
        public string TenHP
        {
            set => lblTenHocPhan.Text = value;
        }

        public string MaSV
        {
            set => lbMaSV.Text = value;
        }

        public string LopSH
        {
            set => lbLopSH.Text = value;
        }

        public string HoTen
        {
            set => lbHoTen.Text = value;
        }

        public string MaHP
        {
            set => lbNhomHP.Text = value;
        }

        private DateTime _startTime;
        public DateTime StartTime
        {
            set
            {
                lbThoiGianBatDau.Text = value.ToString();
                _startTime = value;
            }
        }

        public DateTime SubmitTime
        {
            set
            {
                lbThoiGianNopBai.Text = value.ToString();
                TimeSpan thoiGianLamBai = value - _startTime;
                int totalMinute = thoiGianLamBai.Hours * 3600 + thoiGianLamBai.Minutes * 60 + thoiGianLamBai.Seconds;
                lbThoiGianLamBai.Text = (totalMinute / 60) + " phút " + (totalMinute % 60) + " giây";
            }
        }

        public int SoLuongCauHoi
        {
            set => lbTongSoCauHoi.Text = value.ToString();
        }

        public double Diem
        {
            set => lbDiem.Text = value.ToString();
        }

        public int SoCauDung
        {
            set => lbSoCauDung.Text = value.ToString();
        }

        private void flowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (UC_DapAnPhucKhao uc in flowLayoutPanel.Controls)
            {
                uc.Width = flowLayoutPanel.Width - 10;
            }
        }

        private void ShowQuestions(List<CauHoi_DTO> questions)
        {
            for(int i = 0;i < questions.Count;i++)
            {
                UC_DapAnPhucKhao ans = new UC_DapAnPhucKhao()
                {
                    Width = flowLayoutPanel.Width - 10
                };
                string soThuTu = (i + 1) + "/" + questions.Count;
                ans.SetAnswers(soThuTu, questions[i]);
                flowLayoutPanel.Height += ans.Height + 10;
                flowLayoutPanel.Controls.Add(ans);
            }
        }

        private void frmPhucKhao_Load(object sender, EventArgs e)
        {
            List<CauHoi_DTO> questions = BaiKiemTra_BLL.Instance.GetCauHoiPhucKhao(lbMaSV.Text, MaBaiKiemTra);
            if (questions.Count == 0)
            {
                CustomMessageBox.Show("Chưa có dữ liệu về kết quả chi tiết của bài thi này.", "Thông báo",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowQuestions(questions);
            }
        }
    }
}

using GUI.MyUserControls;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhucKhao : Form
    {
        public frmPhucKhao()
        {
            InitializeComponent();
        }
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
                int totalMinute = thoiGianLamBai.Hours * 3600 + thoiGianLamBai.Minutes*60 + thoiGianLamBai.Seconds;
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
            //foreach(UC_DapAnPhucKhao uc in flowLayoutPanel.Controls)
            //{
            //    uc.Width = flowLayoutPanel.Width;
            //}    
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

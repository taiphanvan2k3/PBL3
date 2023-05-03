using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_FinishDoExam : UserControl
    {
        #region Các thuộc tính truyền từ frmEnterPassToDoExam qua
        private string _MaSV { get; set; }
        public string MaSV
        {
            get => _MaSV;
            set
            {
                _MaSV = value;
                lblMSSV.Text = value;
            }
        }

        public string TenSV { set => lblTenSV.Text = value; }
        public string LopSH { set => lblLopSH.Text = value; }
        public string MaHP { set => lblNhomHP.Text = value; }
        public string TenHP { set => lblTenHP.Text = value; }
        public string TenBaiKiemTra { set => lblTenBaiKiemTra.Text = value; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TongSoCauHoi { get; set; }
        public int SoCauDung { get; set; }
        public int SoLanViPham { get; set; }
        public double DiemSo { get; set; }
        #endregion

        public UC_FinishDoExam()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmQuiz ParentForm = this.ParentForm as frmQuiz;
            
            //Vì frmEnterPassToDoExam bị dispose trước đó nên đành truyền user control này lần lượt
            //qua các form để có thể reload lại user control này sau khi sv hoàn thành bài thi
            UC_DoExam uc = ParentForm.ucDoExam as UC_DoExam;
            uc.LoadData();
            ParentForm.Dispose();
        }

        private void UC_FinishDoExam_Load(object sender, EventArgs e)
        {
            dtgv.Rows.Add(StartTime, EndTime, TongSoCauHoi, SoCauDung, SoLanViPham, DiemSo);
            dtgv.Height = dtgv.ColumnHeadersHeight + dtgv.RowTemplate.Height;
        }

        private void btnCaptureScreen_Click(object sender, EventArgs e)
        {
            Rectangle bounds = new Rectangle(panelMain.Location.X, panelMain.Location.Y, panelMain.Width, 280);
            Bitmap screenShot = new Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(screenShot))
            {
                //Tham số đầu tiên:góc trên bên trái của nguồn
                //Tham số thứ hai: góc trên bên trái của đích
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }
            try
            {
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "PNG Image|*.png";
                open.ShowDialog();
                if (open.FileName != "")
                {
                    string fileName = open.FileName;
                    screenShot.Save(fileName);
                    //targetTime = TimeSpan.FromSeconds(5);
                    //timer.Start();
                    iconCheckSaveImage.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

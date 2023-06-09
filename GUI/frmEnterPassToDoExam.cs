using BLL;
using FontAwesome.Sharp;
using GUI.MyCustomControl;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEnterPassToDoExam : Form
    {
        #region Danh sách các thuộc tính cần thiết để truyền giữa các form,tuy hơi nhiều nhưng đỡ truy vấn lại
        public UserControl ucDoExam { get; set; }
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string MaLopSH { get; set; }
        public string MaLopHP { get; set; }
        public string TenLopHP { get; set; }
        public int MaBaiKiemTra { get; set; }
        public string TenBaiKiemTra { get; set; }
        public string MkBaiKiemTra { get; set; }
        public int ThoiGianLamBai { get; set; }
        public int TongSoCauHoi { get; set; }
        #endregion

        public frmEnterPassToDoExam()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            btnShowPass.IconChar = IconChar.Eye;
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == MkBaiKiemTra)
            {
                DialogResult res = CustomMessageBox.Show("Bạn chỉ có thể làm bài kiểm tra này di nhất một lần\n" +
                                   "Bạn có chắc chắn vào làm bài thi không?", "Chú ý",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (res == DialogResult.OK)
                {
                    double? result = BaiKiemTra_BLL.Instance.IsExsitExam(MaSV, MaBaiKiemTra);
                    if (result == null)
                        BaiKiemTra_BLL.Instance.IsDoingExam(MaSV, MaBaiKiemTra);

                    if (result != null && result != -1)
                    {
                        CustomMessageBox.Show("Bạn đã làm bài kiểm tra này rồi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    //BaiKiemTra_BLL.Instance.IsDoingExam(MaSV, MaBaiKiemTra);
                    UtilityClass.OpenNewForm(this, new frmQuiz()
                    {
                        MaSV = this.MaSV,
                        TenSV = this.TenSV,
                        LopSH = this.MaLopSH,
                        MaHP = this.MaLopHP,
                        TenHP = this.TenLopHP,
                        MaBaiKiemTra = this.MaBaiKiemTra,
                        TenBaiKiemTra = this.TenBaiKiemTra,
                        TongSoCauHoi = this.TongSoCauHoi,
                        ThoiGianLamBai = this.ThoiGianLamBai,
                        ucDoExam = this.ucDoExam,
                    });
                }
            }
            else
            {
                CustomMessageBox.Show("Mật khẩu này không chính xác, hãy kiểm tra lại.", "Sai mật khẩu",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            btnShowPass.IconChar = IconChar.EyeSlash;
            txtPass.UseSystemPasswordChar = true;
        }
    }
}

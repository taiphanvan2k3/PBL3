using BLL;
using GUI.MyCustomControl;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddStudentIntoHomeroomClass : Form
    {
        public string MaLopSH { get; set; }
        public frmAddStudentIntoHomeroomClass()
        {
            InitializeComponent();
            MoveFormHelper helper = new MoveFormHelper(this, panelTitle, lblTitle);
            MaLopSH = "21CNTT - DT1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MSSV = txtIdStudent.Texts;
            if (MSSV == "")
            {
                CustomMessageBox.Show("Bạn chưa nhập mã số sinh viên để thêm.", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!SinhVien_BLL.ValidateIDStudent(MSSV))
            {
                CustomMessageBox.Show("Mã sinh viên không hợp lệ hoặc không tồn tại", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MaKhoa = LopSinhHoat_BLL.Instance.GetMaKhoaOfLSH(MaLopSH);
            if (string.IsNullOrEmpty(MaKhoa))
            {
                CustomMessageBox.Show("Hiện tại chưa xác định được mã khoa của lớp sinh hoạt này.", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Lấy ra năm nhập học của sinh viên để xem có phù hợp để thêm vào lớp sinh hoạt này không
                string NamNhapHoc = MSSV.Substring(3, 2);
                if (!MSSV.StartsWith(MaKhoa))
                {
                    CustomMessageBox.Show("Không thể thêm sinh viên này vào lớp sinh hoạt của khoa khác", "Lỗi",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!MaLopSH.StartsWith(NamNhapHoc))
                {
                    CustomMessageBox.Show("Không thể thêm sinh viên này vì năm nhập học\nkhông phù hợp với lớp sinh hoạt này", "Lỗi",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string currentMaLopSH = SinhVien_BLL.GetNameOfHomeroomClass(MSSV);
                    if (currentMaLopSH == null)
                    {
                        bool check = LopSinhHoat_BLL.Instance.InsertStudentIntoClass(MaLopSH, MSSV);
                        if (check)
                        {
                            CustomMessageBox.Show("Thêm thành công sinh viên vào lớp sinh hoạt", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (currentMaLopSH == MaLopSH)
                    {
                        CustomMessageBox.Show("Sinh viên này đã được thêm vào lớp sinh hoạt này rồi", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (currentMaLopSH != MaLopSH)
                    {
                        CustomMessageBox.Show("Sinh viên này đã được thêm vào lớp sinh hoạt khác rồi", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

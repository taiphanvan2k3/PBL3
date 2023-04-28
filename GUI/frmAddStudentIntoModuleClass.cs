using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddStudentIntoModuleClass : Form
    {
        //Truyền qua frmAddStudent MaHP để lát kiểm tra xem sinhvien có phải ở khoa chứa môn học đó không?
        private string MaHP { get; set; }

        private int SoLuongHienTai = -1;
        private int SoLuongToiDa { get; set; }
        private int KiHoc { get; set; }

        private string Thu { get; set; }
        private int TietBD { get; set; }
        private int TietKT { get; set; }

        public delegate void ReloadParentForm();
        public ReloadParentForm reloadDTGV { get; set; }
        private string FileName { get; set; } = string.Empty;
        public frmAddStudentIntoModuleClass()
        {
            InitializeComponent();
        }
        public frmAddStudentIntoModuleClass(string MaHP, int SoLuongToiDa, int KiHoc, string Thu, int TietBD, int TietKT)
        {
            InitializeComponent();
            this.MaHP = MaHP;
            this.SoLuongToiDa = SoLuongToiDa;
            this.KiHoc = KiHoc;
            this.Thu = Thu;
            this.TietBD = TietBD;
            this.TietKT = TietKT;
        }

        private void pnlUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Lựa chọn file để thêm sinh viên vào lớp học phần";
            open.Filter = "Text files (*.csv)|*.csv";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FileName = open.FileName;
            }
        }

        private void txtIdStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtIdStudent.Texts);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdStudent.Texts == "" && FileName == "")
            {
                CustomMessageBox.Show("Bạn chưa nhập mã sinh viên cần thêm");
                return;
            }

            string MaSV = txtIdStudent.Texts;
            if (!SinhVien_BLL.ValidateIDStudent(MaSV))
            {
                CustomMessageBox.Show("Mã sinh viên không hợp lệ hoặc không tồn tại", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MaKhoa = LopHocPhan_BLL.Instance.GetMaKhoaOfLHP(MaHP);
            if (MaSV.StartsWith(MaKhoa) || MaKhoa == "Sư phạm")
            {
                //Kiểm tra số lượng sinh viên hiện tai của lớp học phần trước khi thêm vào
                if (SoLuongHienTai == -1)
                    SoLuongHienTai = LopHocPhan_BLL.Instance.GetNumberOfStudentInClass(MaHP);
                if (SoLuongHienTai == SoLuongToiDa)
                {
                    CustomMessageBox.Show("Số lượng sinh viên đã đạt tối đa, không thể thêm", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Nếu đã thêm sinh viên chuẩn bị thêm thêm thuộc khoa của lớp học phần đó hoặc môn học
                //này là môn đại cương thì CÓ THỂ thêm sinh viên này vào lớp
                List<LopHocPhan_AdminEdit> li = LopHocPhan_BLL.Instance.GetListHocPhanConflictOfStudent
                                                        (MaHP, MaSV, KiHoc, Thu, TietBD, TietKT);
                if (li == null)
                {
                    //Không bị va chạm => Có thể thêm
                    CustomMessageBox.Show("Thêm thành công");
                    LopHocPhan_BLL.Instance.AddStudentIntoClass(MaHP, MaSV);
                    txtIdStudent.Texts = "";
                }
                else if (li.Count == 0)
                {
                    //Sinh viên này đã được thêm vào lớp học phần này
                    CustomMessageBox.Show("Sinh viên này đã được thêm vào lớp học phần này", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else if (li.Count != 0)
                {
                    CustomMessageBox.Show("Không thể thêm sinh viên vào lớp học phần vì bị va chạm lịch học", "Lỗi",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CustomMessageBox.Show("Không thể thêm sinh viên vào lớp học phần thuộc khoa khác", "Lỗi",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reloadDTGV();
            this.Dispose();
        }
    }
}

using BLL;
using DTO;
using GUI.MyCustomControl;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddModuleClass : Form
    {
        public frmAddModuleClass()
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, lblTitle);
        }
        #region  Utility functions
        private void DisableAllButtons()
        {
            //Chỉ enable AddStudent và AssignTeacher khi đã add thành công hoặc LHP đó đã có rồi
            btnAddModuleClass.Enabled = false;
            btnAddStudent.Enabled = false;
            btnAssignTeacher.Enabled = false;
        }

        private void EnableOptionButtons()
        {
            btnAddStudent.Enabled = true;
            btnAssignTeacher.Enabled = true;
        }
        private void SetBackgroundForErrorValue(Guna2TextBox txt)
        {
            txt.FillColor = Color.Red;
            txt.ForeColor = Color.White;

            //Focus vào control này để con trỏ chuột nằm ở vị trí đang nhập để nhập lại
            txt.Focus();
        }

        private void UnsetBackgroundForErrorValue(Guna2TextBox txt)
        {
            txt.FillColor = Color.White;
            txt.ForeColor = Color.FromArgb(138, 138, 138);
        }

        #endregion
        private void frmAddModuleClass_Load(object sender, EventArgs e)
        {
            cbbTenMH.Items.AddRange(MonHoc_BLL.Instance.GetAllMonHoc().ToArray());
        }

        private void txtTenMH_Leave(object sender, EventArgs e)
        {
            if (cbbTenMH.SelectedIndex >= 0 && txtNhomHP.Text != "")
            {
                string MaMH = ((CBBItem)(cbbTenMH.SelectedItem)).Id;
                txtNhomHP.Text = txtNhomHP.Text.ToUpper().Replace("H", "h");
                if (!txtNhomHP.Text.ToUpper().Contains("NH"))
                {
                    //Nếu nhập sai định dạng nhóm học phần
                    SetBackgroundForErrorValue(txtNhomHP);
                    CustomMessageBox.Show("Sai định dạng nhóm học phần. ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblMaHP.Text = MaMH + txtNhomHP.Text.Replace("Nh", ".");
                int NamNhapHoc = Convert.ToInt32(txtNhomHP.Text.Substring(0, txtNhomHP.Text.IndexOf("Nh"))) + 2000;
                int tmp = (DateTime.Now.Year - NamNhapHoc) * 2;
                if (tmp > 8)
                {
                    //Chỉ cho phép tạo lớp học phần cho các khoá đang còn học
                    SetBackgroundForErrorValue(txtNhomHP);
                    CustomMessageBox.Show("Không thể tạo thêm lớp học phần cho khoá này. " +
                        "\nVui lòng tạo lớp học phần ở các khoá sau", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UnsetBackgroundForErrorValue(txtNhomHP);
                    btnAddModuleClass.Enabled = true;
                    int CurrentYear = DateTime.Now.Year;
                    int CurrentMonth = DateTime.Now.Month;
                    if (CurrentMonth >= 1 && CurrentMonth <= 4)
                    {
                        //Kì chẵn
                        lblKiHoc.Text = tmp + "";
                        lblNamHoc.Text = (CurrentYear - 1) + " - " + CurrentYear;
                    }
                    else if (CurrentMonth >= 8 && CurrentMonth <= 11)
                    {
                        //Kì lẻ và đã qua năm học mới
                        lblKiHoc.Text = (tmp + 1) + "";
                        lblNamHoc.Text = (CurrentYear) + " - " + (CurrentYear + 1);
                    }
                }
            }
            else
            {
                lblKiHoc.Text = "Chưa đủ dữ liệu để tính toán";
                lblNamHoc.Text = "Chưa đủ dữ liệu để tính toán";
                DisableAllButtons();
            }
        }

        private void btnAddModuleClass_Click(object sender, EventArgs e)
        {
            CBBItem itemMH = cbbTenMH.SelectedItem as CBBItem;
            LopHocPhan_AdminEdit lhp = new LopHocPhan_AdminEdit()
            {
                MaMH = itemMH.Id,
                MaHP = lblMaHP.Text,
                KiHoc = Convert.ToInt32(lblKiHoc.Text),
                NamHoc = Convert.ToInt32(lblNamHoc.Text.Substring(0, lblNamHoc.Text.IndexOf(" "))),
                SoLuongMax = Convert.ToInt32(txtSoLuongMax.Text)
            };
            int result = LopHocPhan_BLL.Instance.InsertModuleClass(lhp);
            if (result == -1)
            {
                CustomMessageBox.Show("Không thể thêm vì mã lớp học phần này đã tồn tại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableOptionButtons();
            }
            else if (result == 1)
            {
                CustomMessageBox.Show("Thêm mới thành công lớp học phần vào hệ thống.", "Thông báo");
                //Phải thêm giảng viên trước
                btnAssignTeacher.Enabled = true;
            }
        }

        private void txtSoLuongMax_TextChanged(object sender, EventArgs e)
        {
            btnAddModuleClass.Enabled = false;
            if (txtSoLuongMax.Text == "")
            {
                SetBackgroundForErrorValue(txtSoLuongMax);
                DisableAllButtons();
                return;
            }
            int num;
            int.TryParse(txtSoLuongMax.Text, out num);
            if (!(num > 0 && num <= 70))
            {
                SetBackgroundForErrorValue(txtSoLuongMax);
                DisableAllButtons();
            }
            else
            {
                UnsetBackgroundForErrorValue(txtSoLuongMax);
                btnAddModuleClass.Enabled = true;
            }
        }

        private void btnAssignTeacher_Click(object sender, EventArgs e)
        {
            frmAssignTeacher frm = new frmAssignTeacher();
            frm.CheckHasSchedule = false;

            frm.MaHP = lblMaHP.Text;
            frm.TenMH = cbbTenMH.SelectedItem.ToString();
            frm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (lblMaHP.Text == "")
            {
                CustomMessageBox.Show("Không thể thêm sinh viên vì lớp học phần đang tạo chưa có mã học phần", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Khi thay đổi tên môn học hoặc lớp học phần thì disable các button add
            DisableAllButtons();
        }
    }
}

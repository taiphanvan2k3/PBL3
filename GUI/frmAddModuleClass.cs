using BLL;
using DTO;
using GUI.MyCustomControl;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void LoadCBBNamHoc()
        {
            cbbNamHoc.Items.Clear();
            int StartYear = Convert.ToInt32(txtNhomHP.Text.Substring(0, 2)) + 2000;
            int tmp = StartYear;
            do
            {
                cbbNamHoc.Items.Add(new CBBItem()
                {
                    Id = StartYear.ToString(),
                    Value = StartYear + " - " + (StartYear + 1)
                });
                StartYear++;
            } while (StartYear <= DateTime.Now.Year - 1);

            cbbKiHoc.Items.Clear();
            for (int i = 1; i <= (StartYear - tmp) * 2; i++)
                cbbKiHoc.Items.Add(i);
        }

        private void cbbTenMH_Leave(object sender, EventArgs e)
        {
            if (cbbTenMH.SelectedIndex >= 0 && txtNhomHP.Text != "")
            {
                string TenMH = cbbTenMH.SelectedItem.ToString();
                lblMaHP.Text = UtilityClass.GetFirstCharactersOfString(TenMH) + txtNhomHP.Text.Replace("Nh", ".");
                LoadCBBNamHoc();
            }
        }

        private void btnAddModuleClass_Click(object sender, EventArgs e)
        {
            if (lblMaHP.Text != "" && txtSoLuongMax.FillColor == Color.White && cbbKiHoc.SelectedIndex >= 0)
            {
                LopHocPhan_AdminEdit lhp = new LopHocPhan_AdminEdit()
                {
                    MaHP = lblMaHP.Text,
                    KiHoc = Convert.ToInt32(cbbKiHoc.SelectedItem),
                    NamHoc = Convert.ToInt32(((CBBItem)cbbNamHoc.SelectedItem).Id),
                    SoLuongMax = Convert.ToInt32(txtSoLuongMax.Text)
                };
            }
            else
            {
                CustomMessageBox.Show("Thông tin bạn nhập \"BỊ THIẾU\" hoặc \"KHÔNG HỢP LỆ\"." +
                    "\nVui lòng KIỂM TRA LẠI thông tin và thử lại sau.", "Chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSoLuongMax_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongMax.Text == "")
                return;
            int num;
            int.TryParse(txtSoLuongMax.Text, out num);
            if (!(num > 0 && num <= 70))
            {
                txtSoLuongMax.FillColor = Color.Red;
                txtSoLuongMax.ForeColor = Color.White;
            }
            else
            {
                txtSoLuongMax.FillColor = Color.White;
                txtSoLuongMax.ForeColor = Color.FromArgb(138, 138, 138);
            }
        }
    }
}

using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddHomeroomClass : Form
    {

        // Khai báo delegate và event
        public delegate void DataAddedSuccessHandler();
        public event DataAddedSuccessHandler DataAddedSuccessEvent;
        public frmAddHomeroomClass()
        {
            InitializeComponent();
        }

        private void txtNumberMaxStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAddHomeroomClass_Load(object sender, EventArgs e)
        {
            cmbListFacluty.Items.AddRange(Khoa_BLL.Instance.GetAllKhoa().ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void cmbListFacluty_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            enableBtn();
            cmbTeacher.SelectedIndex = -1;
            cmbTeacher.Items.Clear();   
            CBBItem item = cmbListFacluty.SelectedItem as CBBItem;
            if (item != null)
            {
                cmbTeacher.Items.AddRange(GiangVien_BLL.Instance.GetTeacherByFaculuty(item.Id.ToString(), layTatCaKiTuDauCuaChuoi(item.Value.ToString())).ToArray());
            }

        }

        public static string layTatCaKiTuDauCuaChuoi(string str)
        {
            str = convertToUnSign3(str);
            string[] arrListStr = str.Split(' ');
            string result;
            string maKhoa = "";
            foreach (string str2 in arrListStr)
            {
                result = str2.Substring(0, 1);
                maKhoa += result;
            }
            maKhoa = maKhoa.ToUpper();
            return maKhoa;
        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maHP = cmbYear.SelectedItem.ToString().Substring(2) + layTatCaKiTuDauCuaChuoi(cmbListFacluty.SelectedItem.ToString()) + " - " + layTatCaKiTuDauCuaChuoi(cmbProgramingList.SelectedItem.ToString());
            int count = LopSinhHoat_BLL.Instance.GetLastNumberInMaLopSH(maHP);
            count++;
            maHP += count.ToString();
            CBBItem item = cmbTeacher.SelectedItem as CBBItem;
            string maGv = item.Id.ToString();
            int num;
            int.TryParse(txtNumberMaxStudent.Texts, out num);
            if (LopSinhHoat_BLL.Instance.AddNewHomeroomClass(maHP, maGv, num))
            {
                DialogResult result = CustomMessageBox.Show("Thêm mới thành công!\n Bạn có muốn tiếp tục thêm mới hay không",
                     "Thông báo",
                     MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BlindData();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                    // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
                    DataAddedSuccessEvent?.Invoke();
                }
            }
            else
            {
                CustomMessageBox.Show("Không thể thêm vì mã lớp học phần này đã tồn tại!\n Vui lòng kiểm tra lại thông tin", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BlindData()
        {
            cmbListFacluty.SelectedIndex = -1;
            cmbProgramingList.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;
            cmbTeacher.Items.Clear();
            txtNumberMaxStudent.Texts = "";
        }


        private void enableBtn()
        {
            if (cmbListFacluty.SelectedItem != null && cmbProgramingList.SelectedItem != null && cmbTeacher.SelectedItem != null
            && cmbYear.SelectedItem != null && !string.IsNullOrWhiteSpace(txtNumberMaxStudent.Texts) && labelErr.Visible == false)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cmbProgramingList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            enableBtn();
        }

        private void txtNumberMaxStudent__TextChanged(object sender, EventArgs e)
        {
            int num;
            int.TryParse(txtNumberMaxStudent.Texts, out num);
            if (!(num > 0 && num <= 50))
            {
                labelErr.Visible = true;
                enableBtn();
            }
            else
            {
                labelErr.Visible = false;
                enableBtn();
            }
        }
    }
}

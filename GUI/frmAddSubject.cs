using BLL;
using DTO;
using GUI.MyCustomControl;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddSubject : Form
    {

        private string maMH { get; set; }
        // Khai báo delegate và event
        public delegate void DataAddedSuccessHandler();
        public event DataAddedSuccessHandler DataAddedSuccessEvent;
        
        public frmAddSubject(string maMH)
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, lblTitle);
            this.maMH = maMH;
        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {
            string TenMH = txtTenMH.Texts;
            //Lấy các kí tự đầu của môn học
            if (TenMH != "")
                txtMaMH.Text = UtilityClass.GetFirstCharactersOfString(TenMH);
            else 
                txtMaMH.Text = "...";
        }

        private void toggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch.Checked)
            {
                groupBoxCTDT_PBL.Visible = true;
                groupCTDT.Visible = false;
            }
            else
            {
                groupBoxCTDT_PBL.Visible = false;
                groupCTDT.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
            DataAddedSuccessEvent?.Invoke();
        }

        private string GetCongThucTinhDiem()
        {
            string CtTinhDiem = null;
            Guna2GroupBox groupBox = null;
            if (toggleSwitch.Checked)
            {
                //Đang chọn Đồ án/PBL
                groupBox = groupBoxCTDT_PBL;
            }
            else
            {
                groupBox = groupCTDT;
            }

            foreach (Control c in groupBox.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    if (radioButton.Checked)
                    {
                        CtTinhDiem = UtilityClass.SplitCongThucTinhDiem(radioButton.Text);
                        break;
                    }
                }
            }
            return CtTinhDiem;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            string CtTinhDiem = GetCongThucTinhDiem();
            if (txtTenMH.Texts == "" || cbbKhoa.SelectedIndex == -1 || cbbSoTC.SelectedIndex == -1 || CtTinhDiem == null)
                check = false;
            if (check)
            {
                CBBItem item = cbbKhoa.SelectedItem as CBBItem;
                MonHoc_DTO mh = new MonHoc_DTO()
                {
                    MaMH = txtMaMH.Text,
                    TenMH = txtTenMH.Texts,
                    SoTC = Convert.ToInt32(cbbSoTC.SelectedItem),
                    MaKhoa = item.Id,
                    CtTinhDiem = CtTinhDiem
                };
                int result = MonHoc_BLL.Instance.InsertSubject(mh);
                if (result == -1)
                {
                    CustomMessageBox.Show("Đã tồn tại môn học này trong hệ thống.", "Lỗi",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == 1)
                    CustomMessageBox.Show("Thêm mới thành công 1 môn học.");
            }
            else
            {
                CustomMessageBox.Show("Thông tin về môn học chưa được điền đủ", "Chú ý",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAddSubject_Load(object sender, EventArgs e)
        {

            cbbKhoa.Items.AddRange(Khoa_BLL.Instance.GetAllKhoa().ToArray());
            if (maMH != "")
            {

            }

        }
    }
}

using BLL;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_CreateTestQuestions : UserControl
    {
        public UC_CreateTestQuestions(string id)
        {
            InitializeComponent();
            LoadInfo(id);
        }
        void LoadInfo(string id)
        {
            cbLopHocPhan.Items.Add("Chọn lớp học phần");
            cbLopHocPhan.Items.AddRange(GiangVien_BLL.Instance.GetClassSectionByID(id).ToArray());
            cbLopHocPhan.SelectedIndex = 0;
            cbLoaiBaiKiemTra.SelectedIndex = 0;
            cbSoLuongCauHoi.SelectedIndex = 0;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(tbTenBaiKiemTra.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập tên bài kiểm tra!");
            else if(tbThoiGianLamBai.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập thời gian làm bài!");
            else if(tbMatKhauLamBai.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập mật khẩu làm bài!");
            else
            {

            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {

        }
    }
}

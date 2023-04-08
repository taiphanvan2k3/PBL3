using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class uC_StudentInfo : UserControl
    {
        public uC_StudentInfo()
        {
            InitializeComponent();
        }

        #region properties
        public string HoVaTen
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        public string NgaySinh
        {
            get => txtNgaySinh.Text;
            set => txtNgaySinh.Text = value;
        }

        public string NoiSinh
        {
            get
            {
                if (comboBoxNoiSinh.SelectedIndex >= 0)
                    return comboBoxNoiSinh.Text;
                return "empty";
            }
            set => comboBoxNoiSinh.SelectedItem = value;
        }

        public string DanToc
        {
            get
            {
                if (comboBoxDanToc.SelectedIndex >= 0)
                    return comboBoxDanToc.Text;
                return "empty";
            }
            set => comboBoxDanToc.SelectedItem = value;
        }

        public string QuocTinh
        {
            get
            {
                if (comboBoxQuocTinh.SelectedIndex >= 0)
                    return comboBoxQuocTinh.Text;
                return "empty";
            }
            set => comboBoxQuocTinh.SelectedItem = value;
        }

        public string CCCD
        {
            get => txtCCCD.Text;
            set => txtCCCD.Text = value;
        }

        public bool GioiTinh
        {
            get
            {
                if (txtGioiTinh.Text == "" || txtGioiTinh.Text == "Nam")
                    return true;
                return false;
            }
            set
            {
                if (value)
                    txtGioiTinh.Text = "Nam";
                else txtGioiTinh.Text = "Nữ";
            }
        }

        public string Khoa
        {
            get => txtKhoa.Text;
            set => txtKhoa.Text = value;
        }

        public string ChuongTrinhDaoTao
        {
            get => txtCTDT.Text;
            set => txtCTDT.Text = value;
        }

        public string LopSinhHoat
        {
            get => txtLopSH.Text;
            set => txtLopSH.Text = value;
        }

        public string SoDienThoai
        {
            get => txtSDT.Text;
            set => txtSDT.Text = value;
        }

        public string EmailCaNhan
        {
            get => txtEmailCaNhan.Text;
            set => txtEmailCaNhan.Text = value;
        }

        public string SoNha
        {
            get => txtSoNha.Text;
            set => txtSoNha.Text = value;
        }

        public void SetDiaChi(string address)
        {
            string[] tmp = UtilityClass.SplitAddress(address);
            uC_AddressSelectionCaNhan.TinhThanhPho = tmp[0];
            uC_AddressSelectionCaNhan.QuanHuyen = tmp[1];
            uC_AddressSelectionCaNhan.XaPhuong = tmp[2];
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string res = uC_AddressSelectionCaNhan.TinhThanhPho + "," + uC_AddressSelectionCaNhan.QuanHuyen + "," + uC_AddressSelectionCaNhan.XaPhuong;
            MessageBox.Show(res);
        }

        public void setComboBoxNoiSinh(List<string> li)
        {
            comboBoxNoiSinh.Items.AddRange(li.ToArray());
        }

        private void comboBoxNoiSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;
            cbb.Select(0, 0);
        }
    }
}

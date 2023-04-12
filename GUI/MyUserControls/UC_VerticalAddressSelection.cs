using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_VerticalAddressSelection : UserControl
    {
        public UC_VerticalAddressSelection()
        {
            InitializeComponent();
        }
        void Init()
        {
            comboBoxTinhThanhPho.Items.Add(new CBBItem() { Id = "0", Value = "Chọn Tỉnh/ Thành phố" });
            comboBoxTinhThanhPho.Items.AddRange(AddressSelection_BLL.Instance.GetAllCities().ToArray());
            comboBoxTinhThanhPho.SelectedIndex = 0;
        }
        public Color Background
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
            }
        }

        public Color BorderColorComboBox
        {
            get => comboBoxQuanHuyen.BorderColor;
            set
            {
                comboBoxQuanHuyen.BorderColor = value;
                comboBoxTinhThanhPho.BorderColor = value;
                comboBoxXaPhuong.BorderColor = value;
            }
        }
        public int WidthOfControl
        {
            set => this.Width = value;
        }
        private void SetSelectedItemForCBB(string value, ComboBox cbb)
        {
            foreach (var item in cbb.Items)
            {
                CBBItem address = item as CBBItem;
                if (address.Value == value)
                {
                    cbb.SelectedItem = address;
                    break;
                }
            }
        }
        public string TinhThanhPho
        {
            get
            {
                if (comboBoxTinhThanhPho.SelectedIndex > 0)
                    return comboBoxTinhThanhPho.SelectedItem.ToString();
                return "";
            }
            set
            {
                SetSelectedItemForCBB(value, comboBoxTinhThanhPho);
            }
        }

        public string QuanHuyen
        {
            get
            {
                if (comboBoxQuanHuyen.SelectedIndex >= 0)
                    return comboBoxQuanHuyen.SelectedItem.ToString();
                return "";
            }
            set
            {
                SetSelectedItemForCBB(value, comboBoxQuanHuyen);
            }
        }

        public string XaPhuong
        {
            get
            {
                if (comboBoxXaPhuong.SelectedIndex >= 0)
                    return comboBoxXaPhuong.SelectedItem.ToString();
                return "";
            }
            set
            {
                SetSelectedItemForCBB(value, comboBoxXaPhuong);
            }
        }

        public void SetDiaChi(string address)
        {
            string[] tmp = UtilityClass.SplitAddress(address);
            this.TinhThanhPho = tmp[0];
            this.QuanHuyen = tmp[1];
            this.XaPhuong = tmp[2];
        }
        private void comboBoxTinhThanhPho_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxTinhThanhPho.SelectedIndex > 0)
            {
                comboBoxQuanHuyen.Items.Clear();
                comboBoxXaPhuong.Text = "";
                comboBoxQuanHuyen.Items.Add(new CBBItem() { Id = "0", Value = "Chọn Quận/ Huyện" });
                comboBoxQuanHuyen.SelectedIndex = 0;
                CBBItem item = comboBoxTinhThanhPho.SelectedItem as CBBItem;
                int city_id = Convert.ToInt32(item.Id);
                comboBoxQuanHuyen.Items.AddRange(AddressSelection_BLL.Instance.GetDistrictRecords(city_id).ToArray());
            }
        }

        private void comboBoxQuanHuyen_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxQuanHuyen.SelectedIndex > 0)
            {
                comboBoxXaPhuong.Items.Clear();
                comboBoxXaPhuong.Items.Add(new CBBItem() { Id = "0", Value = "Chọn Xã/ Phường" });
                comboBoxXaPhuong.SelectedIndex = 0;
                CBBItem item = comboBoxQuanHuyen.SelectedItem as CBBItem;
                int district_id = Convert.ToInt32(item.Id);
                comboBoxXaPhuong.Items.AddRange(AddressSelection_BLL.Instance.GetWardRecords(district_id).ToArray());
            }
        }

        private void comboBoxTinhThanhPho_Click(object sender, EventArgs e)
        {
            if (comboBoxTinhThanhPho.Items.Count == 0)
                Init();
        }
    }
}

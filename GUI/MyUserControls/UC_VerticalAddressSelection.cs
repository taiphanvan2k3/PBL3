using BLL;
using DTO;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_VerticalAddressSelection : UserControl
    {
        public UC_VerticalAddressSelection()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            comboBoxTinhThanhPho.Items.Add(new CBBAddressItem() { Id = 0, Value = "Chọn Tỉnh/ Thành phố" });
            comboBoxTinhThanhPho.Items.AddRange(AddressSelectionBLL.Instance.GetCityRecords().ToArray());
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
                CBBAddressItem address = item as CBBAddressItem;
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
                if (comboBoxTinhThanhPho.SelectedIndex >= 0)
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

        private void UC_AddressSelection_Load(object sender, System.EventArgs e)
        {
            /*comboBoxTinhThanhPho.Items.Add(new CBBAddressItem() { Id = 0, Value = "Chọn Tỉnh/ Thành phố" });
            comboBoxTinhThanhPho.Items.AddRange(AddressSelectionBLL.Instance.GetCityRecords().ToArray());
            comboBoxTinhThanhPho.SelectedIndex = 0;*/
        }

        private void comboBoxTinhThanhPho_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxTinhThanhPho.SelectedIndex > 0)
            {
                comboBoxQuanHuyen.Items.Clear();
                comboBoxXaPhuong.Text = "";
                comboBoxQuanHuyen.Items.Add(new CBBAddressItem() { Id = 0, Value = "Chọn Quận/ Huyện" });
                comboBoxQuanHuyen.SelectedIndex = 0;
                CBBAddressItem item = comboBoxTinhThanhPho.SelectedItem as CBBAddressItem;
                comboBoxQuanHuyen.Items.AddRange(AddressSelectionBLL.Instance.GetDistrictRecords(item.Id).ToArray());
            }
        }

        private void comboBoxQuanHuyen_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxQuanHuyen.SelectedIndex > 0)
            {
                comboBoxXaPhuong.Items.Clear();
                comboBoxXaPhuong.Items.Add(new CBBAddressItem() { Id = 0, Value = "Chọn Xã/ Phường" });
                comboBoxXaPhuong.SelectedIndex = 0;
                CBBAddressItem item = comboBoxQuanHuyen.SelectedItem as CBBAddressItem;
                comboBoxXaPhuong.Items.AddRange(AddressSelectionBLL.Instance.GetWardRecords(item.Id).ToArray());
            }
        }
    }
}

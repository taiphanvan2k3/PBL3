using BLL;
using DTO;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_AddressSelection : UserControl
    {
        public UC_AddressSelection()
        {
            InitializeComponent();
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

        private void UC_AddressSelection_Load(object sender, System.EventArgs e)
        {
            comboBoxTinhThanhPho.Items.Add(new CBBAddressItem() { Id = 0, Value = "Chọn Tỉnh/ Thành phố" });
            comboBoxTinhThanhPho.Items.AddRange(AddressSelectionBLL.Instance.GetCityRecords().ToArray());
            comboBoxTinhThanhPho.SelectedIndex = 0;
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

using BLL;
using DTO;
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
    public partial class UC_AddressSelection_vertical_ : UserControl
    {
        public UC_AddressSelection_vertical_()
        {
            InitializeComponent();
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
                comboBoxTinhThanhPho.SelectedItem = value;
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
                comboBoxQuanHuyen.SelectedItem = value;
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
                comboBoxXaPhuong.SelectedItem = value;
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

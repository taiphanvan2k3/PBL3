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
    public partial class UC_StudentInfo : UserControl
    {
        public UC_StudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = AddressSelectionCaNhan.TinhThanhPho + "," + AddressSelectionCaNhan.QuanHuyen;
            MessageBox.Show(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

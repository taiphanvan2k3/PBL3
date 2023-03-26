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
    public partial class uC_StudentInfo : UserControl
    {
        public uC_StudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = uC_AddressSelectionCaNhan.TinhThanhPho + "," + uC_AddressSelectionCaNhan.QuanHuyen +","+ uC_AddressSelectionCaNhan.XaPhuong;
            MessageBox.Show(res);
        }
    }
}

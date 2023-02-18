using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank()
        {
            InitializeComponent();
        }
        public void Days(int numDay)
        {
            btnDays.Text = numDay + "";
        }
    }
}

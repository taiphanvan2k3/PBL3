using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class testData : Form
    {
        public testData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = GetInformationAcc_BLL.Instance.getTheNumberOfStudentByFaculty(textBox1.Text.ToString().Substring(0, 3), textBox1.Text.ToString().Substring(3));
            MessageBox.Show(result.ToString());
        }
    }
}

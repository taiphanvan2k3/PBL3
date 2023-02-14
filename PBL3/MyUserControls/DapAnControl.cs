using System.Drawing;
using System.Windows.Forms;

namespace PBL3.MyUserControls
{
    public partial class DapAnControl : UserControl
    {
        private int _STT;
        public int STT
        {
            get => _STT;
            set
            {
                labelCauHoi.Text += " " + value;
                _STT = value;
            }
        }

        public string DapAn
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public DapAnControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelCheck.Visible = true;
            }
            else
            {
                labelCheck.Visible = false;
            }
        }
    }
}

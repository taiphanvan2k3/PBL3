using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DapAnControl : UserControl
    {
        private int _STT;
        public int STT
        {
            get => _STT;
            set
            {
                char c = (char)(value - 1 + 'A');
                labelCauHoi.Text += " " + c;
                _STT = value;
            }
        }

        public string DapAn
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public UC_DapAnControl()
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

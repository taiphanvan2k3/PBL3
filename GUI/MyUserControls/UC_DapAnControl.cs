using BLL;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DapAnControl : UserControl
    {
        private int PreviousHeight;
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
            get => txtDapAn.Text;
            set => txtDapAn.Text = value;
        }
        public UC_DapAnControl()
        {
            InitializeComponent();
            PreviousHeight = txtDapAn.MinimumSize.Height;
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (txtDapAn.Text == "")
            {
                labelCheck.Visible = true;
            }
            else
            {
                labelCheck.Visible = false;
                int heightText = UtilityClass.CalculateHeightOfControl(txtDapAn);
                Panel ParentPanel = this.Parent as Panel;
                if (heightText > PreviousHeight)
                {
                    int offset = heightText - PreviousHeight;
                    this.Height += offset;
                    ParentPanel.Height += offset;
                    txtDapAn.Height = heightText;
                    PreviousHeight = heightText;
                }
                else if (heightText < PreviousHeight && heightText >= txtDapAn.MinimumSize.Height)
                {
                    int offset = PreviousHeight - heightText;
                    txtDapAn.Height =heightText;
                    this.Height -= offset;
                    ParentPanel.Height -= offset;
                    PreviousHeight = heightText;
                }
            }
        }
    }
}

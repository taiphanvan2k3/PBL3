using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DapAnPhucKhao : UserControl
    {
        public enum StateAnswer
        {
            Correct,
            InCorrect,
            DoNot
        }

        public StateAnswer state
        {
            set
            {
                if (value == StateAnswer.Correct)
                    BackColor = Color.LightGreen;
                else if (value == StateAnswer.InCorrect)
                    BackColor = Color.LightCoral;
                else 
                    BackColor = Color.LightSalmon;
            }
        }

        public UC_DapAnPhucKhao()
        {
            InitializeComponent();
        }
    }
}

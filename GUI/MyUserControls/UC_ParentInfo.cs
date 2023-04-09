using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ParentInfo : UserControl
    {
        public UC_StudentInfoNew previousPage { get; set; }
        public UC_ParentInfo()
        {
            InitializeComponent();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            Panel pnl = Parent as Panel;
            pnl.Controls.Clear();
            previousPage.Dock = DockStyle.Fill;
            pnl.Controls.Add(previousPage);
        }
    }
}

using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_StudentInfoNew : UserControl
    {
        public UC_ParentInfo nextPage { get; set; }
        public UC_StudentInfoNew()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (nextPage == null)
            {
                nextPage = new UC_ParentInfo();
                nextPage.previousPage = this;
                nextPage.Dock = DockStyle.Fill;
            }
            if (Parent is Panel)
            {
                Panel pnl = Parent as Panel;
                pnl.Controls.Clear();
                pnl.Controls.Add(nextPage);
            }
        }

        private void flowLayoutRight_Resize(object sender, EventArgs e)
        {
            int offset = pnlThongTinDaoTao.Location.Y;
            int heightRemains = flowLayoutRight.Height - pnlThongTinDaoTao.Height -
                                                  pnlDiaChi.Height - pnlThongTinLienLac.Height;
            pnlThongTinDaoTao.Width = flowLayoutRight.Width - 10;
            pnlThongTinDaoTao.Height += (heightRemains - 4 * offset) / 3;

            pnlDiaChi.Width = pnlThongTinDaoTao.Width;
            pnlDiaChi.Height += (heightRemains - 4 * offset) / 3;

            pnlThongTinLienLac.Width = pnlThongTinDaoTao.Width;
            pnlThongTinLienLac.Height += (heightRemains - 4 * offset) / 3 - 5;
        }
    }
}

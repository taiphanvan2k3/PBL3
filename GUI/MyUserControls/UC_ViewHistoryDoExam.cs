using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ViewHistoryDoExam : UserControl
    {
        public UC_ViewHistoryDoExam()
        {
            InitializeComponent();
        }

        private void btnExpandPanelSearch_Click(object sender, EventArgs e)
        {
            if (btnExpandPanelSearch.IconChar == IconChar.AngleDown)
            {
                btnExpandPanelSearch.IconChar = IconChar.AngleUp;
                panelSearch.Height = panelSearch.MaximumSize.Height;
            }
            else
            {
                btnExpandPanelSearch.IconChar = IconChar.AngleDown;
                panelSearch.Height = panelSearch.MinimumSize.Height;
            }
        }

        private void btnExpandPanelShow_Click(object sender, EventArgs e)
        {
            if (btnExpandPanelShow.IconChar == IconChar.AngleDown)
            {
                btnExpandPanelShow.IconChar = IconChar.AngleUp;
                panelShow.Height = panelShow.MaximumSize.Height;
            }
            else
            {
                btnExpandPanelShow.IconChar = IconChar.AngleDown;
                panelShow.Height = panelShow.MinimumSize.Height;
            }
        }

        private void flowLayoutPanelMain_Resize(object sender, EventArgs e)
        {
            int orginalWidthOfPanelSearch = panelSearch.Width;
            //Do các control bên trong flowLayout không thể tự anchor nên phải resize thủ công
            panelSearch.Width = flowLayoutPanelMain.Width - 10;
            panelShow.Width = flowLayoutPanelMain.Width - 10;

            //Thay đổi vị trí của các textbox, combobox ko set anchor trước đó
            double ratio = panelSearch.Width * 1.0 / orginalWidthOfPanelSearch;
            lblHocKy.Location = new Point((int)(lblHocKy.Location.X * ratio), lblHocKy.Location.Y);
            cbbHocKy.Location = new Point(lblHocKy.Location.X, cbbHocKy.Location.Y);

            lblHocphan.Location = new Point((int)(lblHocphan.Location.X * ratio), lblHocphan.Location.Y);
            txtTenHP.Location = new Point(lblHocphan.Location.X, txtTenHP.Location.Y);
        }

        private void panelDTGV_Paint(object sender, PaintEventArgs e)
        {
            //Do các control bên trong flowLayout không thể tự anchor nên phải resize thủ công
            dtgv.Width = panelDTGV.Width - 20;
        }
    }
}

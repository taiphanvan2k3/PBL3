using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLopArrowDown_Click(object sender, EventArgs e)
        {
            timerExpandClass.Start();
        }

        private void timerExpandClass_Tick(object sender, EventArgs e)
        {
            if (panelLop.Height == 153)
            {
                for (int i = 153; i >= 53; i--)
                    panelLop.Height = i;
                timerExpandClass.Stop();
                btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                isExpandingClass = false;
            }
            else
            {
                for (int i = 53; i <= 153; i++)
                    panelLop.Height = i;
                timerExpandClass.Stop();
                btnLopArrowDown.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                isExpandingClass = true;
            }
        }

        private void btnCalendarExpand_Click(object sender, EventArgs e)
        {
            timerExpandCalendar.Start();
        }

        private void timerExpandCalendar_Tick(object sender, EventArgs e)
        {
            if (panelCalendar.Height == 156)
            {
                for (int i = 156; i >= 53; i--)
                    panelCalendar.Height = i;
                timerExpandCalendar.Stop();
                btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                isExpandingCalendar = false;
            }
            else
            {
                for (int i = 53; i <= 156; i++)
                    panelCalendar.Height = i;
                timerExpandCalendar.Stop();
                btnCalendarExpand.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                isExpandingCalendar = true;
            }
        }

        private Point originalLocationOfBtnMenuExpand;

        //Hai biến bool này để lưu trạng thái đóng mở của panelLop, panelCalendar
        //để khi panelMenuTong đưa về trạng thái mở rộng ban đầu thì hiển thị lại trạng thái đóng, mở tương
        //ứng đó
        private bool isExpandingClass = false;
        private bool isExpandingCalendar = false;
        private void btnExpandMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuTong.Width == 237)
            {
                originalLocationOfBtnMenuExpand = btnExpandMenu.Location;
                pictureBoxMenu.Visible = false;
                btnExpandMenu.Location = pictureBoxMenu.Location;
                panelMenuTong.Width = 63;
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MinimumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MinimumSize.Height;
                panelShowDetail.Location = new Point(panelShowDetail.Location.X - (237 - 63), panelShowDetail.Location.Y);
                panelShowDetail.Width += (237 - 63);
            }
            else
            {
                panelMenuTong.Width = 237;
                pictureBoxMenu.Visible = true;
                btnExpandMenu.Location = originalLocationOfBtnMenuExpand;
                if (isExpandingCalendar)
                    panelCalendar.Height = panelCalendar.MaximumSize.Height;
                if (isExpandingClass)
                    panelLop.Height = panelLop.MaximumSize.Height;
                panelShowDetail.Location = new Point(panelShowDetail.Location.X + (237 - 63), panelShowDetail.Location.Y);
                panelShowDetail.Width -= (237 - 63);
            }
        }


    }
}

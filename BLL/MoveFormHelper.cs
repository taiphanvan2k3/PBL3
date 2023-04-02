using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    /// <summary>
    /// Lớp này phục vụ cho việc cầm kéo di chuyển các form mà có BorderStyle = None
    /// </summary>
    public class MoveFormHelper
    {
        private Form frm;
        private Panel panelTitle;
        private Label lbl;
        public MoveFormHelper(Form frm, Panel panelTitle, Label lbl)
        {
            this.frm = frm;
            this.lbl = lbl;
            this.panelTitle = panelTitle;
            addEvent();
        }

        private void addEvent()
        {
            panelTitle.MouseDown += panelTitle_MouseDown;
            lbl.MouseDown += panelTitle_MouseDown;

            panelTitle.MouseMove += panelTitle_MouseMove;
            lbl.MouseMove += panelTitle_MouseMove;

            panelTitle.MouseUp += panelTitle_MouseUp;
            lbl.MouseUp += panelTitle_MouseUp;
        }
        #region Xử lí di chuyển form khi cầm vào thanh tiêu đề
        #region các thuộc tính xử lí form di chuyển
        private bool move;
        private int moveX, moveY;
        #endregion
        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                //set lại vị trí của form trên màn hình
                frm.SetDesktopLocation(Form.MousePosition.X - moveX, Form.MousePosition.Y - moveY);
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //Chỉ xử lí việc di chuyển form khi nhấn chuột trái
            if (e.Button == MouseButtons.Left)
            {
                move = true;
                moveX = e.X;
                moveY = e.Y;
            }
        }
        #endregion
    }
}

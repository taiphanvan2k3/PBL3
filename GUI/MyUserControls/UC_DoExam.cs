using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DoExam : UserControl
    {
        private frmEnterPassToDoExam frmEnterPass;
        public UC_DoExam()
        {
            InitializeComponent();
        }

        private void UC_DoExam_Load(object sender, EventArgs e)
        {
            dtgv.Columns["LamBai"].DefaultCellStyle.Padding = new Padding(50, 2, 50, 2);
            dtgv.Rows.Add("CSDL21.13", "Cơ sở dữ liệu", "Thi giữa kì CSDL", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Thi giữa kì OOP", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Test01", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Test02", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Test03", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("CSDL21.13", "Cơ sở dữ liệu", "Thi giữa kì CSDL", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Thi giữa kì OOP", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Test01", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Test02", "50 câu", "1 tiếng", "");
            dtgv.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Test03", "50 câu", "1 tiếng", "");
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                frmEnterPass = new frmEnterPassToDoExam();
                frmEnterPass.Location = new Point(700, 0);
                frmEnterPass.StartPosition = FormStartPosition.Manual;
                timerPopupForm.Start();
                frmEnterPass.ShowDialog();
            }
        }

        private void dtgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Fill the background of the button with a blue color
                e.PaintBackground(e.CellBounds, true);
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    Rectangle buttonBounds = e.CellBounds;
                    int buttonWidth = 100;
                    int buttonHeight = 25;
                    buttonBounds.Width = buttonWidth;
                    buttonBounds.Height = buttonHeight;

                    //Tính toán toạ độ trên bên trái để bắt đầu vẽ HCN bên trong
                    buttonBounds.X += (e.CellBounds.Width - buttonWidth) / 2;
                    buttonBounds.Y += (e.CellBounds.Height - buttonHeight) / 2;
                    e.Graphics.FillRectangle(brush, buttonBounds);

                    //Vẽ text vào giữa HCN bên trong
                    string buttonText = "Làm bài";
                    Font buttonFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    // Measure the size of the button text
                    SizeF textSize = e.Graphics.MeasureString(buttonText, buttonFont);
                    // Calculate the center point of the button
                    float centerX = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float centerY = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;
                    // Draw the button text in the center of the button
                    using (Brush brushDrawString = new SolidBrush(Color.White))
                    {
                        e.Graphics.DrawString(buttonText, buttonFont, brushDrawString, centerX, centerY);
                    }
                }
                e.Handled = true;
            }
        }

        private void timerPopupForm_Tick(object sender, EventArgs e)
        {
            while (frmEnterPass.Location.Y < this.Location.Y + 100)
            {
                frmEnterPass.Location = new Point(frmEnterPass.Location.X, frmEnterPass.Location.Y + 1);
            }
        }
    }
}

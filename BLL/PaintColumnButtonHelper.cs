using System.Drawing;
using System.Windows.Forms;

namespace BLL
{
    public class PaintColumnButtonHelper
    {
        private string _buttonText;
        private DataGridView _dataGridView;
        public PaintColumnButtonHelper(DataGridView dataGridView, string buttonText)
        {
            _dataGridView = dataGridView;
            _buttonText = buttonText;
            _dataGridView.CellPainting += DataGridView_CellPainting;
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && _dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Fill the background of the button with a blue color
                e.PaintBackground(e.CellBounds, true);
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    //Vẽ text vào giữa HCN bên trong
                    Font buttonFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

                    //Tính toán kích thước của text, kích thước này phụ thuộc vào font đang sử dụng
                    SizeF textSize = e.Graphics.MeasureString(_buttonText, buttonFont);

                    Rectangle buttonBounds = e.CellBounds;
                    int buttonWidth = (int)textSize.Width + 20;
                    int buttonHeight = (int)textSize.Height;

                    buttonBounds.Width = buttonWidth;
                    buttonBounds.Height = buttonHeight;

                    //Tính toán toạ độ trên bên trái để bắt đầu vẽ HCN bên trong
                    buttonBounds.X += (e.CellBounds.Width - buttonWidth) / 2;
                    buttonBounds.Y += (e.CellBounds.Height - buttonHeight) / 2;
                    e.Graphics.FillRectangle(brush, buttonBounds);

                    //Tính toán vị trí bắt đầu vẽ sao cho text nằm giữa button
                    float centerX = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float centerY = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;

                    //Vẽ text ở giữa button
                    using (Brush brushDrawString = new SolidBrush(Color.White))
                    {
                        e.Graphics.DrawString(_buttonText, buttonFont, brushDrawString, centerX, centerY);
                    }
                }
                e.Handled = true;
            }
        }
    }
}

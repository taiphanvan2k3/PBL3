using System;
using System.Drawing;
using System.Windows.Forms;

namespace BLL
{
    /// <summary>
    /// Do các đoạn code xử lí sau được dùng lại ở UC_DailyWorkShedule và UC_WeeklySchedule nên để tránh
    /// việc viết đi viết lại, không clean code nên đã tách ra lớp này để tái sử dụng
    /// </summary>
    public class ViewWorkScheduleHelper
    {
        //Do ở BLL không thể gọi các form ở GUI nên phải để các thao tác liên quan đến các form đó
        //tại GUI và ở đây gọi delegate để xử lí
        public delegate void ViewListStudent(string MaLopHP);
        public ViewListStudent del_ViewListStudent { get; set; }

        public delegate void SendNotification(string MaLopHP);
        public SendNotification del_SendNotification { get; set; }


        private DataGridView dtgv;
        public ViewWorkScheduleHelper(DataGridView dtgv)
        {
            this.dtgv = dtgv;
            dtgv.DataSourceChanged += dtgv_DataSourceChanged;
            dtgv.CellPainting += dtgv_CellPainting;
            dtgv.CellContentClick += dtgv_CellContentClick;
        }
        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            dtgv.Columns["SoTC"].Visible = false;
            dtgv.Columns["TenGV"].Visible = false;
            dtgv.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Xem danh sách lớp", Name = "XemDanhSach" });
            dtgv.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Thông báo đến lớp", Name = "ThongBao" });

            int CurrentRows = dtgv.RowCount;
            if (dtgv.RowCount == 0)
                CurrentRows = 1;
            dtgv.Height = dtgv.ColumnHeadersHeight + CurrentRows * dtgv.RowTemplate.Height;

            //Tính toán khoảng padding cần set cho 2 cột DataGridViewButtonColumn để chỉ khi nào bấm vào ô HCN
            //tượng trưng cho button thì event CellContentClick mới được phát sinh
            int WidthColumnXemDanhSach = dtgv.Columns["XemDanhSach"].Width;
            int padding1 = (WidthColumnXemDanhSach - 50) / 2;
            dtgv.Columns["XemDanhSach"].DefaultCellStyle.Padding = new Padding(padding1, 5, padding1, 5);

            int WidthColumnThongBao = dtgv.Columns["ThongBao"].Width;
            int padding2 = (WidthColumnThongBao - 90) / 2;
            dtgv.Columns["ThongBao"].DefaultCellStyle.Padding = new Padding(padding2, 5, padding2, 5);
        }

        private void dtgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Vẽ text cho các cột là DataGridViewButtonColumn
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.PaintBackground(e.CellBounds, true);
                using (Brush brush = new SolidBrush(Color.SkyBlue))
                {
                    Rectangle buttonBounds = e.CellBounds;
                    int buttonWidth;
                    int buttonHeight = 23;

                    string buttonText = "";
                    if (e.ColumnIndex == 6)
                    {
                        buttonText = "Xem";
                        buttonWidth = 50;
                    }
                    else
                    {
                        buttonText = "Thông báo";
                        buttonWidth = 90;
                    }

                    buttonBounds.Width = buttonWidth;
                    buttonBounds.Height = buttonHeight;

                    //Tính toán toạ độ trên bên trái để bắt đầu vẽ HCN bên trong
                    buttonBounds.X += (e.CellBounds.Width - buttonWidth) / 2;
                    buttonBounds.Y += (e.CellBounds.Height - buttonHeight) / 2;
                    e.Graphics.FillRectangle(brush, buttonBounds);

                    Font buttonFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

                    //Tính toán kích thước của text, kích thước này phụ thuộc vào font đang sử dụng
                    SizeF textSize = e.Graphics.MeasureString(buttonText, buttonFont);

                    //Tính toán vị trí bắt đầu vẽ sao cho text nằm giữa button
                    float centerX = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float centerY = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;

                    //Vẽ text ở giữa button
                    using (Brush brushDrawString = new SolidBrush(Color.White))
                    {
                        e.Graphics.DrawString(buttonText, buttonFont, brushDrawString, centerX, centerY);
                    }
                }
                e.Handled = true;
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if (e.ColumnIndex == 6)
                {
                    string MaLopHP = dtgv.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();
                    //Gọi đến phương thức HandleEventViewListStudentInModuleClass
                    del_ViewListStudent(MaLopHP);
                }
                else if (e.ColumnIndex == 7)
                {
                    string MaLopHP = dtgv.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();
                    //Gọi đến phương thức HandleEventSendNotificationToModuleClass
                    del_SendNotification(MaLopHP);
                }
            }
        }
    }
}

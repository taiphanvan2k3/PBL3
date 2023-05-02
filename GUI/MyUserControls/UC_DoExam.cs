using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DoExam : UserControl
    {
        //Truyền MaSV vào để truy vấn các bài kiểm tra
        public string MaSV { get; set; }
        public string TenSV { get; set; }

        //Truyền LopSH này vào để lát nếu làm vào làm bài kiểm tra thì hiển thị tên lớp của sinh viên này
        //ra, đỡ phải vào CSDL truy vấn tốn thời gian trong khi có thể tận dụng được từ frmExam
        public string LopSH { get; set; }

        private frmEnterPassToDoExam frmEnterPass;
        public UC_DoExam()
        {
            InitializeComponent();
        }

        private void UC_DoExam_Load(object sender, EventArgs e)
        {
            List<BaiKiemTra_DTO> li = BaiKiemTra_BLL.Instance.GetAllExamOfStudent("102210043");
            //Add thêm bài kiểm tra để dễ test
            li.Add(new BaiKiemTra_DTO()
            {
                MaBaiKiemTra = 1,
                MaHP = "OOP21.13",
                TenMH = "Lập trình hướng đối tượng",
                TieuDeBaiKiemTra = "Thi giữa kì OOP",
                SoCauHoi = 50,
                ThoiGianLamBai = 50,
                ThoiGianBatDau = DateTime.Now,
                MkBaiKiemTra = "Gk2113"
            });

            li.Add(new BaiKiemTra_DTO()
            {
                MaBaiKiemTra = 2,
                MaHP = "OOAD21.13",
                TenMH = "Phân tích và thiết kế hướng đối tượng",
                TieuDeBaiKiemTra = "Bài test 01",
                SoCauHoi = 100,
                ThoiGianLamBai = 90,
                ThoiGianBatDau = DateTime.Now,
                MkBaiKiemTra = "Test01OOAD"
            });
            dtgv.Columns.Clear();
            dtgv.DataSource = li;
        }
        private void UC_DoExam_SizeChanged(object sender, EventArgs e)
        {
            //Mỗi khi UC này thay đổi kích thước thì chiều cao của header sẽ bị thay đổi do đó nếu muốn
            //chiều cao của dtgv vừa khít với số lượng dòng thì phải đi tính toán lại Height của dtgv trong event này
            dtgv.Height = dtgv.ColumnHeadersHeight + dtgv.RowCount * dtgv.RowTemplate.Height;
        }

        private void ChangeColumnsProperty()
        {
            dtgv.Columns["MaHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv.Columns["tenMH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dtgv.Columns["LamBai"].Width = 50;
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            //Vì vẫn muốn hai cột bị ẩn đi nhưng vẫn có thể truy cập được nên sẽ không sử dụng Browsable(false)
            dtgv.Columns["MkBaiKiemTra"].Visible = false;
            dtgv.Columns["MaBaiKiemTra"].Visible = false;
            dtgv.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Làm bài", Name = "LamBai" });
            ChangeColumnsProperty();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];
                string tmp = row.Cells["ThoiGianLamBai_Show"].Value.ToString();
                int minutes = Convert.ToInt32(tmp.Substring(0, tmp.IndexOf(" ")));
                tmp = row.Cells["SoLuongCauHoi_Show"].Value.ToString();
                int TongSoCau = Convert.ToInt32(tmp.Substring(0, tmp.IndexOf(" ")));
                frmEnterPass = new frmEnterPassToDoExam
                {
                    MaSV = this.MaSV,
                    TenSV = this.TenSV,
                    MaLopSH = LopSH,
                    MaLopHP = row.Cells["MaHP"].Value.ToString(),
                    TenLopHP = row.Cells["TenMH"].Value.ToString(),
                    MaBaiKiemTra = Convert.ToInt32(row.Cells["MaBaiKiemTra"].Value),
                    TenBaiKiemTra = row.Cells["TieuDeBaiKiemTra"].Value.ToString(),
                    MkBaiKiemTra = row.Cells["MkBaiKiemTra"].Value.ToString(),
                    TongSoCauHoi = TongSoCau,
                    ThoiGianLamBai = minutes,
                    Location = new Point(700, 0),
                    StartPosition = FormStartPosition.Manual
                };
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
                    int buttonWidth = 80;
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
            if(frmEnterPass.Location.Y>= this.Location.Y + 100)
            {
                timerPopupForm.Stop();
                return;
            }

            while (frmEnterPass.Location.Y < this.Location.Y + 100)
            {
                frmEnterPass.Location = new Point(frmEnterPass.Location.X, frmEnterPass.Location.Y + 1);
            }
        }

        private void flowPanel_SizeChanged(object sender, EventArgs e)
        {
            dtgv.Width = flowPanel.Width - 5;
            panelButton.Width = flowPanel.Width - 5;
        }

    }
}

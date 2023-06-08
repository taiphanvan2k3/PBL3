using BLL;
using DTO;
using GUI.MyCustomControl;
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
        private bool IsInitted = false;
        public UC_DoExam()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<BaiKiemTra_DTO> li = BaiKiemTra_BLL.Instance.GetAllExamOfStudent(MaSV);
            dtgv.DataSource = li;
        }

        private void UC_DoExam_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeColumnsProperty()
        {
            dtgv.Columns["tenMH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dtgv_DataSourceChanged(object sender, EventArgs e)
        {
            //Vì vẫn muốn hai cột bị ẩn đi nhưng vẫn có thể truy cập được nên sẽ không sử dụng Browsable(false)
            dtgv.Columns["MkBaiKiemTra"].Visible = false;
            dtgv.Columns["MaBaiKiemTra"].Visible = false;
            if (!IsInitted)
            {
                dtgv.Columns.Add(new DataGridViewButtonColumn() { HeaderText = "Làm bài", Name = "LamBai" });
                IsInitted = true;
            }
            ChangeColumnsProperty();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];

                /*Do property ThoiGianLamBai có Browsable(false) nên không thể truy cập nó từ dtgv
                  Nên phải truy cập thông qua ThoiGianLamBai_Show, và ThoiGianLamBai_Show có giá trị vd 60 phút
                  nên phải cần thêm bước Substring nữa để lấy ra thời gian
                 */

                //DateTime startTime = Convert.ToDateTime(row.Cells["ThoiGianBatDau"].Value);
                //DateTime endTime = Convert.ToDateTime(row.Cells["ThoiGianKetThuc"].Value);
                //DateTime nowTime = DateTime.Now;
                //if (!(startTime <= nowTime && nowTime <= endTime))
                //{
                //    CustomMessageBox.Show("Đây không phải là thời điểm để làm bài kiểm tra này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
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

                    //Thiết lập StartPosition là Manual để làm hiệu ứng form di chuyển từ trên xuống
                    Location = new Point(700, 0),
                    StartPosition = FormStartPosition.Manual,
                    ucDoExam = this
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

        private void timerPopupForm_Tick(object sender, EventArgs e)
        {
            if (frmEnterPass.Location.Y >= this.Location.Y + 100)
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

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

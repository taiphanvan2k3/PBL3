using BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    /// <summary>
    /// User control này dùng để xem danh sách lớp học phần mà sinh viên này đang theo
    /// học theo kì, được dùng trong frmStudent
    /// </summary>
    public partial class UC_ViewListModuleClass_SVRole : UserControl
    {
        public string MaSV { get; set; }
        private bool IsInitted { get; set; } = false;
        public UC_ViewListModuleClass_SVRole()
        {
            InitializeComponent();
        }

        private void LoadCBBKiHoc()
        {
            int NamNhapHoc = Convert.ToInt32(MaSV.Substring(3, 2)) + 2000;
            int NamHienTai = DateTime.Now.Year;
            int stt = 1;
            for (int i = NamNhapHoc; i <= NamHienTai - 1; i++)
            {
                string str1 = "Học kỳ " + (stt++) + " ( năm học " + i + "-" + (i + 1) + " )";
                string str2 = "Học kỳ " + (stt++) + " ( năm học " + i + "-" + (i + 1) + " )";
                cbbKiHoc.Items.AddRange(new string[]
                {
                    str1,str2
                });
            }

            int CurrentMonth = DateTime.Now.Month;
            if (CurrentMonth >= 8 && CurrentMonth <= 11)
                cbbKiHoc.Items.Add("Học kỳ " + stt + " ( năm học " + NamHienTai + "-" + (NamHienTai + 1) + " )");
            cbbKiHoc.SelectedIndex = cbbKiHoc.Items.Count - 1;
        }

        private void UC_ViewListModuleClass_SVRole_Load(object sender, System.EventArgs e)
        {
            LoadCBBKiHoc();
        }

        private void cbbKiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKiHoc.SelectedIndex >= 0)
            {
                int KiHoc = cbbKiHoc.SelectedIndex + 1;
                dtgv.DataSource = SinhVien_BLL.GetLichHocTrongTuan(MaSV, KiHoc);
                if (!IsInitted)
                {
                    DataGridViewButtonColumn viewListColumn = new DataGridViewButtonColumn()
                    {
                        HeaderText = "Xem danh sách",
                        Name = "XemDanhSach",
                    };
                    dtgv.Columns.Add(viewListColumn);

                    //Đánh dấu là đã thêm 2 cột ButtonColumn vào dtgv, tránh việc mỗi lần SelectedIndexChanged
                    //thì lại thêm 2 cột đó vào nữa
                    IsInitted = true;
                }
                dtgv.Columns["STT"].Width = 100;
                dtgv.Columns["MaHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dtgv.Columns["SoTC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dtgv.Columns["TenHP"].Width = 320;
                dtgv.Height = dtgv.ColumnHeadersHeight + dtgv.RowCount * dtgv.RowTemplate.Height; 
            }
        }

        private void dtgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Vẽ text cho các cột là DataGridViewButtonColumn
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                //50 là chiều rộng HCN được vẽ trong các ô của column XemDanhSach
                //Tính toán padding như này để chỉ khi nào nhấn vào chính xác ô HCN thì mới phát sinh event
                int paddingLeft = (dtgv.Columns["XemDanhSach"].Width - 50) / 2;
                dtgv.Columns["XemDanhSach"].DefaultCellStyle.Padding = new Padding(paddingLeft, 0, paddingLeft, 0);

                e.PaintBackground(e.CellBounds, true);
                using (Brush brush = new SolidBrush(Color.SkyBlue))
                {
                    Rectangle buttonBounds = e.CellBounds;
                    int buttonWidth = 50;
                    int buttonHeight = 23;

                    string buttonText = "Xem";

                    /*Thay đổi Width,Height trên buttonBounds không ảnh hưởng đến e.Bounds
                    vì e.Bounds chỉ có get chứ không có set nên e.Bounds chỉ là value chứ không phải variable
                    Nên chỉ có thể lấy giá trị ra từ nó chứ không thể set vào*/
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
            if (e.RowIndex >= 0 && dtgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string MaLopHP = dtgv.Rows[e.RowIndex].Cells["MaHP"].Value.ToString();
                frmShowListStudentInModuleClass frm = new frmShowListStudentInModuleClass()
                {
                    MaHP = MaLopHP
                };
                frm.ShowDialog();
            }
        }
    }
}

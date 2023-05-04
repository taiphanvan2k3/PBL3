using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmShowEventInDay : Form
    {
        public string Date { get; set; }
        public List<BaiKiemTra_DTO> listExams { get; set; }
        public frmShowEventInDay()
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, labelTitle);
        }

        private void frmShowEventInDay_Load(object sender, EventArgs e)
        {
            labelTitle.Text = "Danh sách các bài kiểm tra ngày " + Date;
            dtgv.DataSource = listExams;
            dtgv.Columns["MaBaiKiemTra"].Visible = false;
            dtgv.Columns["MkBaiKiemTra"].Visible = false;
            dtgv.Columns["MaHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgv.Columns["TenMH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv.Height = dtgv.ColumnHeadersHeight + dtgv.RowCount * dtgv.RowTemplate.Height;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

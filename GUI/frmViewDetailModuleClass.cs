using BLL;
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
    public partial class frmViewDetailModuleClass : Form
    {
        /// <summary>
        /// Form này dùng để hiển thị ra thông tin chi tiết của một lớp học phần nào đó.
        /// Ở đây có thể edit các thông tin của lớp học phần, xem danh sách sinh viên của lớp
        /// học phần đó, phân công giảng viên,...
        /// </summary>
        public frmViewDetailModuleClass()
        {
            InitializeComponent();
            new MoveFormHelper(this, panelTitle, labelTitle);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_ViewDetailModuleClass_Load(object sender, EventArgs e)
        {
            //Dữ liệu này chỉ phục vụ việc test giao diện
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Rows.Add(1, "102210207", "Võ Phước Hoàng", "21TCLC_DT3", "0911...");
            dataGridView1.Rows.Add(2, "102210216", "Trần Đình Mạnh", "21TCLC_DT3", "0905...");
            dataGridView1.Rows.Add(3, "102210218", "Trần Phương Nam", "21TCLC_DT3", "0912...");
            dataGridView1.Rows.Add(4, "102210219", "Phan Thành Ngân", "21TCLC_DT3", "0912...");
            dataGridView1.Rows.Add(5, "102210224", "Lê Thành Nhựt", "21TCLC_DT3", "0913...");
            dataGridView1.Rows.Add(6, "102210228", "Mai Trịnh Xuân Quý", "21TCLC_DT3", "0914...");
            dataGridView1.Rows.Add(7, "102210230", "Phan Văn Tài", "21TCLC_DT3", "0905...");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
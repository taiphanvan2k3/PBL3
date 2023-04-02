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
    public partial class frmAssignTeacher : Form
    {
        public frmAssignTeacher()
        {
            InitializeComponent();
            MoveFormHelper helper = new MoveFormHelper(this, panelTitle, labelTitle);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_AssignTeacher_Load(object sender, EventArgs e)
        {
            //Dữ liệu này dùng để test giao diện,khi triển khai sẽ thay bằng việc set dữ liệu cho DataTable
            //bằng cách lấy dữ liệu ở DB lên
            dtgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Rows.Add(1, "102bk0001", "Lê Thị Mỹ Hạnh", "0905...", 2);
            dtgv.Rows.Add(2, "102bk0002", "Nguyễn Văn A", "0911...", 3);
            dtgv.Rows.Add(3, "102bk0003", "Huỳnh Thị B", "0912...", 2);
            dtgv.Rows.Add(4, "102bk0003", "Võ Văn C", "0913...", 2);
            dtgv.Rows.Add(5, "102bk0004", "Lê Văn D", "0914...", 1);
        }
    }
}

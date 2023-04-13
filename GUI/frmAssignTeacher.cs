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

        #region Properties
        public string MaHP
        {
            get => tbMaHP.Text;
            set => tbMaHP.Text = value;
        }
        public string TenHP
        {
            get => tbTenHP.Text;
            set => tbTenHP.Text = value;
        }
        public string MaGV
        {
            get => tbMaGV.Text;
            set => tbMaGV.Text = value;
        }
        public string TenGV
        {
            get => tbTenGV.Text; 
            set => tbTenGV.Text = value;
        }
        public string Thu
        {
            get => tbThu.Text;
            set => tbThu.Text = value;
        }
        public string TietBatDau
        {
            get => tbTietBD.Text;
            set => tbTietBD.Text = value;
        }
        public string TietKetThuc
        {
            get => tbTietKT.Text;
            set => tbTietKT.Text = value;
        }
        public string Phong
        {
            get => tbPhong.Text; 
            set => tbPhong.Text = value;
        }
        #endregion
        #region Events
        private void frm_AssignTeacher_Load(object sender, EventArgs e)
        {
            dtgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
            dtgv.Refresh();
            int stt = 1;
            foreach(var i in GiangVien_BLL.Instance.GetGiangVienWithNumberLHP())
            {
                dtgv.Rows.Add(stt, i.MaGV, i.TenGV, i.SDT, i.SoLuongHPPhuTrach);
                stt++;
            }
        }
        //Bắt sự kiện cho button chọn trong Datagridview
        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgv.Columns["xacNhan"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];
                //Xử lí sự kiện khi nhấn button Phân công ở chỗ này. Xử lí theo row đã lấy ở dòng trên
                //MessageBox.Show(row.Cells[0].Value.ToString());
                tbMaGV.Texts = row.Cells[1].Value.ToString();
                tbTenGV.Texts = row.Cells[2].Value.ToString();
            }
        }
        #endregion
    }
}

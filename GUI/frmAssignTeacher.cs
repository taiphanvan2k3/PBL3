using BLL;
using DTO;
using GUI.MyCustomControl;
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
        public bool checkHaveSchedule { get; set; }
        private const int maxRow = 6;
        private int currentPage, maxPage;
        private List<AssignTeacher> li;
        private SplitPageHelper<AssignTeacher> helper;
        public frmAssignTeacher()
        {
            InitializeComponent();
            MoveFormHelper helper = new MoveFormHelper(this, panelTitle, labelTitle);
        }
        public void LoadData()
        {
            dtgv.Rows.Clear();
            dtgv.Refresh();
            li = GiangVien_BLL.Instance.GetGiangVienWithNumberLHP();
            currentPage = 1;
            maxPage = (int)Math.Ceiling(li.Count * 1.0 / maxRow);
            helper = new SplitPageHelper<AssignTeacher>(maxRow, li);
            foreach (var i in helper.GetRecords(currentPage))
            {
                dtgv.Rows.Add(i.STT, i.MaGV, i.TenGV, i.SDT, i.SoLuongHPPhuTrach);
            }
        }
        #region Properties
        public string MaHP
        {
            get => tbMaHP.Texts;
            set
            {
                tbMaHP.Texts = value;
            }
        }
        public string TenMH
        {
            get => tbTenMH.Texts;
            set => tbTenMH.Texts = value;
        }
        public string MaGV
        {
            get => tbMaGV.Texts;
            set => tbMaGV.Texts = value;
        }
        public string TenGV
        {
            get => tbTenGV.Texts;
            set => tbTenGV.Texts = value;
        }
        public string Thu
        {
            get => cbbThu.SelectedText;
            set => cbbThu.SelectedText = value;
        }
        public string TietBatDau
        {
            get => cbbTietBD.SelectedText;
            set => cbbTietBD.SelectedText = value;
        }
        public string TietKetThuc
        {
            get => cbbTietKT.SelectedText;
            set => cbbTietKT.SelectedText = value;
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
            //dtgv.Rows.Clear();
            //dtgv.Refresh();
            LoadData();
            
        }
        //Bắt sự kiện cho button chọn trong Datagridview
        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgv.Columns["xacNhan"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];
                //Xử lí sự kiện khi nhấn button Phân công ở chỗ này. Xử lí theo row đã lấy ở dòng trên
                tbMaGV.Texts = row.Cells[1].Value.ToString();
                tbTenGV.Texts = row.Cells[2].Value.ToString();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                dtgv.Rows.Clear();
                dtgv.Refresh();
                currentPage--;
                foreach (var i in helper.GetRecords(currentPage))
                {
                    dtgv.Rows.Add(i.STT, i.MaGV, i.TenGV, i.SDT, i.SoLuongHPPhuTrach);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentPage < maxPage)
            {
                dtgv.Rows.Clear();
                dtgv.Refresh();
                currentPage++;
                foreach (var i in helper.GetRecords(currentPage))
                {
                    dtgv.Rows.Add(i.STT, i.MaGV, i.TenGV, i.SDT, i.SoLuongHPPhuTrach);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(cbbThu.SelectedItem.ToString() == null || tbPhong.Text == "" || cbbTietBD.SelectedItem.ToString() == null || cbbTietKT.SelectedItem.ToString() == null)
            {
                CustomMessageBox.Show("Thông tin lịch học không được để trống!");
            }
            else if(tbMaGV.Texts == "")
            {
                CustomMessageBox.Show("Vui lòng chọn giảng viên!");
            }
            else if(Convert.ToInt32(cbbTietBD.SelectedItem.ToString()) >= Convert.ToInt32(cbbTietKT.SelectedItem.ToString()))
                CustomMessageBox.Show("Tiết bắt đầu sai lệch so với tiết kết thúc!");
            else
            {
                if (GiangVien_BLL.Instance.CheckTKBGiangVienConflict(tbMaGV.Texts, cbbThu.SelectedItem.ToString(), Convert.ToInt32(cbbTietBD.SelectedItem.ToString()), Convert.ToInt32(cbbTietKT.SelectedItem.ToString())))
                {
                    //Chỗ này sẽ gọi tới hàm truy vấn vào csdl để sửa đổi thông tin giảng viên của LHP
                    GiangVien_BLL.Instance.AssignTeacherToSectionClass(tbMaGV.Texts, cbbThu.SelectedItem.ToString(), Convert.ToInt32(cbbTietBD.SelectedItem.ToString()), Convert.ToInt32(cbbTietKT.SelectedItem.ToString()), tbPhong.Text, tbMaHP.Texts);
                    CustomMessageBox.Show("Phân công giảng viên thành công!");
                    this.Dispose();
                }
                else
                    CustomMessageBox.Show("Lịch dạy của giảng viên bị xung đột!");
            }
        }
        #endregion

    }
}

using BLL;
using DTO;
using GUI.MyCustomControl;
using GUI.MyUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddStudentIntoMClass : Form
    {
        //Truyền qua frmAddStudent MaHP để lát kiểm tra xem sinhvien có phải ở khoa chứa môn học đó không?
        private string MaHP { get; set; }

        private int SoLuongHienTai = -1;
        private int SoLuongToiDa { get; set; }
        private int KiHoc { get; set; }

        private string Thu { get; set; }
        private int TietBD { get; set; }
        private int TietKT { get; set; }

        private string MaKhoa { get; set; }

        // Phục vụ tìm kiếm
        private AutoCompleteStringCollection autotext;

        public delegate void ReloadParentForm();
        public ReloadParentForm reloadDTGV { get; set; }
        private string FileName { get; set; } = string.Empty;

        //----------------------------------------------


        private List<KeyValuePair<string, string>> list;
        UC_DatagirdviewCheckbox myUserControl;
        private List<string> nameHeader = new List<string> { "", "Mã SV", "Họ tên" };


        private DataTable dt;

        public DataTable ConvertListToDataTable(List<KeyValuePair<string, string>> list)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Key", typeof(string));
            dataTable.Columns.Add("Value", typeof(string));

            foreach (var item in list)
            {
                dataTable.Rows.Add(item.Key, item.Value);
            }

            return dataTable;
        }

        public frmAddStudentIntoMClass(string MaHP, int SoLuongToiDa, int KiHoc, string Thu, int TietBD, int TietKT)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(this);
            this.MaHP = MaHP;
            this.SoLuongToiDa = SoLuongToiDa;
            this.KiHoc = KiHoc;
            this.Thu = Thu;
            this.TietBD = TietBD;
            this.TietKT = TietKT;
            this.MaKhoa = GiangVien_BLL.Instance.GetMaKhoaByMaLHP(MaHP);

            list = LopHocPhan_BLL.Instance.GetListStundent_v2(MaKhoa, MaHP);
            dt = ConvertListToDataTable(list);
            autotext = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            autotext.AddRange(list.Select(x => x.Key).ToArray());
            txtSearch.AutoCompleteCustomSource = autotext;
            myUserControl = new UC_DatagirdviewCheckbox(dt, nameHeader);
            myUserControl.Dock = DockStyle.Fill;
            panelView.Controls.Add(myUserControl);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && FileName == "")
            {
                CustomMessageBox.Show("Bạn chưa nhập mã sinh viên cần thêm");
                return;
            }

            string MaSV = txtSearch.Text;
            if (!SinhVien_BLL.ValidateIDStudent(MaSV))
            {
                CustomMessageBox.Show("Mã sinh viên không hợp lệ hoặc không tồn tại", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MaKhoa = LopHocPhan_BLL.Instance.GetMaKhoaOfLHP(MaHP);
            if (MaSV.StartsWith(MaKhoa) || MaKhoa == "Sư phạm")
            {
                //Kiểm tra số lượng sinh viên hiện tai của lớp học phần trước khi thêm vào
                if (SoLuongHienTai == -1)
                    SoLuongHienTai = LopHocPhan_BLL.Instance.GetNumberOfStudentInClass(MaHP);
                if (SoLuongHienTai == SoLuongToiDa)
                {
                    CustomMessageBox.Show("Số lượng sinh viên đã đạt tối đa, không thể thêm", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Nếu đã thêm sinh viên chuẩn bị thêm thêm thuộc khoa của lớp học phần đó hoặc môn học
                //này là môn đại cương thì CÓ THỂ thêm sinh viên này vào lớp
                List<LopHocPhan_AdminEdit> li = LopHocPhan_BLL.Instance.GetListHocPhanConflictOfStudent
                                                        (MaHP, MaSV, KiHoc, Thu, TietBD, TietKT);
                if (li == null)
                {
                    //Không bị va chạm => Có thể thêm
                    CustomMessageBox.Show("Thêm thành công");
                    LopHocPhan_BLL.Instance.AddStudentIntoClass(MaHP, MaSV);
                    txtSearch.Text = "";
                }
                else if (li.Count == 0)
                {
                    //Sinh viên này đã được thêm vào lớp học phần này
                    CustomMessageBox.Show("Sinh viên này đã được thêm vào lớp học phần này", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else if (li.Count != 0)
                {
                    CustomMessageBox.Show("Không thể thêm sinh viên vào lớp học phần vì bị va chạm lịch học", "Lỗi",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CustomMessageBox.Show("Không thể thêm sinh viên vào lớp học phần thuộc khoa khác", "Lỗi",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            reloadDTGV();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Key like '%{0}%'", txtSearch.Text);
            myUserControl.loadData(dv.ToTable());
        }
    }
}

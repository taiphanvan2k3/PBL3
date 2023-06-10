using BLL;
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
    public partial class frmAddStudentIntoHClass : Form
    {
        public string MaLopSH { get; set; }

        Regex regex = new Regex(@"\D+");
        private List<KeyValuePair<string, string>> list;
        UC_DatagirdviewCheckbox myUserControl;
        private List<string> nameHeader = new List<string>{"", "Mã SV", "Họ tên"};


        private DataTable dt;

        // Phục vụ tìm kiếm
        private AutoCompleteStringCollection autotext;

        //Số lượng sinh viên tối đa của lớp sinh hoạt này
        private int MaxNumberOfStudent;

        //Số lượng sinh viên hiện tại của lớp sinh hoạt, lưu như này để kiểm tra LSH có đầy chưa
        //trước khi thêm sinh viên
        private int CurrentNumberStudent = 0;
        public delegate void ReloadParentForm();
        public ReloadParentForm reloadDTGV { get; set; }

        public frmAddStudentIntoHClass()
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(this);
            MaLopSH = "21CNTT - CLC1";
        }
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


        public frmAddStudentIntoHClass(string MaLopSH, int MaxNumberOfStudent)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(this);
            this.MaLopSH = MaLopSH;
            this.MaxNumberOfStudent = MaxNumberOfStudent;
            list = LopSinhHoat_BLL.Instance.listOfStudentsWithoutClass(regex.Match(this.MaLopSH).Value, MaLopSH.Substring(0, 2));
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
            string MSSV = txtSearch.Text;
            if (MSSV == "")
            {
                CustomMessageBox.Show("Bạn chưa nhập mã số sinh viên để thêm.", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!SinhVien_BLL.ValidateIDStudent(MSSV))
            {
                CustomMessageBox.Show("Mã sinh viên không hợp lệ hoặc không tồn tại", "Lỗi",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MaKhoa = LopSinhHoat_BLL.Instance.GetMaKhoaOfLSH(MaLopSH);
            if (string.IsNullOrEmpty(MaKhoa))
            {
                CustomMessageBox.Show("Hiện tại chưa xác định được mã khoa của lớp sinh hoạt này.", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Lấy ra năm nhập học của sinh viên để xem có phù hợp để thêm vào lớp sinh hoạt này không
                string NamNhapHoc = MSSV.Substring(3, 2);
                if (!MSSV.StartsWith(MaKhoa))
                {
                    CustomMessageBox.Show("Không thể thêm sinh viên này vào lớp sinh hoạt của khoa khác", "Lỗi",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!MaLopSH.StartsWith(NamNhapHoc))
                {
                    CustomMessageBox.Show("Không thể thêm sinh viên này vì năm nhập học\nkhông phù hợp với lớp sinh hoạt này", "Lỗi",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string currentMaLopSH = SinhVien_BLL.GetNameOfHomeroomClass(MSSV);
                    if (currentMaLopSH == null)
                    {
                        //Nếu sinh viên đó chưa có lớp sinh hoạt thì có thể thêm vào lớp này.
                        //Nhưng phải kiểm tra lớp sinh hoạt đã đầy chưa trước khi thêm.
                        if (CurrentNumberStudent == 0)
                            CurrentNumberStudent = LopSinhHoat_BLL.Instance.GetNumberOfStudent(MaLopSH);
                        if (CurrentNumberStudent == MaxNumberOfStudent)
                        {
                            CustomMessageBox.Show("Số lượng sinh viên đang đạt tối đa, không thể thêm", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            bool check = LopSinhHoat_BLL.Instance.InsertStudentIntoClass(MaLopSH, MSSV);
                            if (check)
                            {
                                CustomMessageBox.Show("Thêm thành công sinh viên vào lớp sinh hoạt", "Thông báo",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CurrentNumberStudent++;
                            }
                        }
                    }
                    else if (currentMaLopSH == MaLopSH)
                    {
                        CustomMessageBox.Show("Sinh viên này đã được thêm vào lớp sinh hoạt này rồi", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (currentMaLopSH != MaLopSH)
                    {
                        CustomMessageBox.Show("Sinh viên này đã được thêm vào lớp sinh hoạt khác rồi", "Thông báo",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

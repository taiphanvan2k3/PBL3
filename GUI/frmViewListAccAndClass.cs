using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Reflection;
using GUI.MyCustomControl;
using Testexcel;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class frmViewListAccAndClass : Form
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;
        string maLop = "";
        string maID = "";

        // Phục vụ tìm kiếm
        private AutoCompleteStringCollection autotext;
        private string previousValue;



        List<string> listOfStudentCodesToDelete = new List<string>();

        private List<object> dt;
        private int role;
        public frmViewListAccAndClass(List<object> dt, int role)
        {
            InitializeComponent();
            HideButton();
            this.dt = dt;
            this.role = role;
        }
        private void dgvViewAcc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if the cell being edited is not in the first column
            if (e.ColumnIndex != 0)
            {
                // Cancel the edit operation
                e.Cancel = true;
            }
        }
        private void HideButton()
        {
            btnDelete.Visible = false;
            btnEdit.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadData()
        {
            switch (role)
            {
                case 0:
                    dgvViewAcc.DataSource = GetInformationAcc_BLL.Instance.GetAccountStudentList();
                    break;
                case 1:
                    dgvViewAcc.DataSource = GetInformationAcc_BLL.Instance.GetAccountTeacherList();
                    break;
                case 2:
                    dgvViewAcc.DataSource = LopSinhHoat_BLL.Instance.GetInformationClasses();
                    break;
                case 3:
                    dgvViewAcc.DataSource = LopSinhHoat_BLL.Instance.GetInformationClasses();
                    break;
            }
        }
        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBL3DataSet.NGUOI_DUNG' table. You can move, or remove it, as needed.
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvViewAcc.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            dgvViewAcc.DataSource = dt;
            BindGridView();
            autotext = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            switch (role)
            {
                case 0:
                    UtilityClass.SwapColumns(dgvViewAcc, 1, 2);
                    dgvViewAcc.Columns[7].Visible = false;
                    dgvViewAcc.Columns[8].Visible = false;
                    dgvViewAcc.Columns[9].Visible = false;
                    autotext.AddRange(dt.Select(x => ((InformationStudent_DTO)x).TaiKhoan + " - " + ((InformationStudent_DTO)x).Ten).ToArray());
                    txtSearch.AutoCompleteCustomSource = autotext;
                    break;
                case 1:
                    UtilityClass.SwapColumns(dgvViewAcc, 1, 2);
                    dgvViewAcc.Columns[7].Visible = false;
                    dgvViewAcc.Columns[8].Visible = false;
                    dgvViewAcc.Columns[9].Visible = false;
                    autotext.AddRange(dt.Select(x => ((InformationTeacher_DTO)x).TaiKhoan + " - " + ((InformationTeacher_DTO)x).Ten).ToArray());
                    txtSearch.AutoCompleteCustomSource = autotext;

                    break;
                case 2:
                    dgvViewAcc.Columns[3].Visible = false;
                    lbTitle.Text = "Quản lý lớp sinh hoạt";
                    btnAdd.Text = "Thêm lớp học";
                    btnAdd.Click -= btnAdd_Click;
                    btnAdd.Click += btnAddHomeroomClass_Click;
                    btnEdit.Click -= btnEdit_Click;
                    btnEdit.Click += btnEditHomeRoomClass_Click;
                    autotext.AddRange(dt.Select(x => ((InformationClass_DTO)x).maLop + " - " + ((InformationClass_DTO)x).tenLop).ToArray());
                    txtSearch.AutoCompleteCustomSource = autotext;
                    break;
                case 3:
                    lbTitle.Text = "Quản lý lớp học phần";
                    btnAdd.Text = "Thêm lớp học";
                    btnAdd.Click -= btnAdd_Click;
                    btnAdd.Click += btnAddMoudleClass_Click;
                    btnEdit.Click -= btnEdit_Click;
                    btnEdit.Click += btnEditMoudleClass_Click;
                    autotext.AddRange(dt.Select(x => ((InformationClass_DTO)x).maLop + " - " + ((InformationClass_DTO)x).tenLop).ToArray());
                    txtSearch.AutoCompleteCustomSource = autotext;
                    break;
            }
        }

        #region Thêm header checkbox
        private void BindGridView()
        {
            dgvViewAcc.CurrentCell = null;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Name = "checkBoxColumn";
            dgvViewAcc.Columns.Insert(0, checkBoxColumn);
            TotalCheckBoxes = dgvViewAcc.RowCount;
            TotalCheckedCheckBoxes = 0;
        }

        private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvViewAcc.CurrentCell is DataGridViewCheckBoxCell)
                dgvViewAcc.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            dgvViewAcc.CurrentCell = null;
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            HeaderCheckBox.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            //Add the CheckBox into the DataGridView
            this.dgvViewAcc.Controls.Add(HeaderCheckBox);
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            //Get the column header cell bounds
            Rectangle oRectangle = this.dgvViewAcc.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);
            Point oPoint = new Point();
            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2;
            //Change the location of the CheckBox to make it stay on the header
            HeaderCheckBox.Location = oPoint;
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvViewAcc.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value = HCheckBox.Checked;
            }
            dgvViewAcc.RefreshEdit();
            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;
            IsHeaderCheckBoxClicked = false;
        }


        #endregion

        #region Sự kiện nhấn vào 1 ô checkbox
        //Kiểm tra xem checkbox được đánh dấu ở header của datagridview có được chọn hay không.
        private void dgvViewAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop to verify whether all row CheckBoxes are checked or not.
                bool isChecked = true;
                foreach (DataGridViewRow row in dgvViewAcc.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                HeaderCheckBox.Checked = isChecked;
            }
        }

        private void dgvViewAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkCell = dgvViewAcc.Rows[e.RowIndex].Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (checkCell != null)
                {
                    bool isChecked = (bool)checkCell.EditedFormattedValue;
                    dgvViewAcc.Rows[e.RowIndex].Selected = isChecked;
                    int selectedRowCount = dgvViewAcc.SelectedRows.Count;

                    if (isChecked)
                    {
                        dgvViewAcc.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
                        dgvViewAcc.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                        TotalCheckedCheckBoxes++;
                        maID = dgvViewAcc.Rows[e.RowIndex].Cells[2].Value.ToString();
                        maLop = dgvViewAcc.Rows[e.RowIndex].Cells[1].Value.ToString();
                        listOfStudentCodesToDelete.Add(maID);
                    }
                    else
                    {
                        dgvViewAcc.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
                        dgvViewAcc.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromName("ActiveCaption");
                        TotalCheckedCheckBoxes--;
                        maID = dgvViewAcc.Rows[e.RowIndex].Cells[2].Value.ToString();
                        listOfStudentCodesToDelete.Remove(maID);
                    }

                    if (TotalCheckedCheckBoxes > 1)
                    {
                        // Nếu chọn nhiều hàng
                        btnEdit.Visible = false;
                        btnDelete.Visible = true;
                    }
                    else if (TotalCheckedCheckBoxes == 1)
                    {
                        // Nếu chỉ chọn một hàng
                        btnEdit.Visible = true;
                        btnDelete.Visible = true;
                    }
                    else
                    {
                        // Không chọn hàng nào
                        HideButton();
                    }
                }

            }
        }

        #endregion

        #region Xử lý sự kiện CRUD tài khoản
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show("Lựa chọn chế độ muốn thêm tài khoản mới",
                "Tạo Tài Khoản",
                MessageBoxButtons.YesNoCancel, "Thủ Công", "Bằng Sheet", "Hủy");
            if (result == DialogResult.Yes)
            {
                frmAddAccount frmAddAccStudent = new frmAddAccount(role, "");
                // Đăng ký sự kiện DataAddedSuccessEvent và gán method loadData vào
                frmAddAccStudent.DataAddedSuccessEvent += loadData;
                frmAddAccStudent.ShowDialog();


            }
            else if (result == DialogResult.No)
            {
                frmAddAccountByExcel frmAddAccountByExcel = new frmAddAccountByExcel(role);
                frmAddAccountByExcel.ShowDialog();
            }
            else if (result == DialogResult.Cancel)
            {
                // Code xử lý khi người dùng chọn Cancel
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dgvViewAcc.CurrentRow;
            //string mssv = row.Cells[2].Value.ToString();
            //MessageBox.Show(mssv);
            //if (GetInformationAcc_BLL.Instance.DeleteStudent(mssv)) {
            //    MessageBox.Show("Thanfh cong");
            //}
            //if (GetInformationAcc_BLL.Instance.DeleteUser(mssv))
            //{
            //    MessageBox.Show("Thanfh cong");
            //}
            //if (GetInformationAcc_BLL.Instance.DeleteLoginInfo(mssv))
            //{
            //    MessageBox.Show("Thanfh cong");
            //}
            foreach (var item in listOfStudentCodesToDelete)
            {
                if (GetInformationAcc_BLL.Instance.DeleteData(role, item))
                {
                    MessageBox.Show("Xóa acc thành công:" + item);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            if (role == 0)
            {
                dgvViewAcc.DataSource = GetInformationAcc_BLL.Instance.GetAccountStudentList();
            }
            else
            {
                dgvViewAcc.DataSource = GetInformationAcc_BLL.Instance.GetAccountTeacherList();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccStudent = new frmAddAccount(role, maID);
            frmAddAccStudent.ShowDialog();
        }
        #endregion

        #region Xử lý sự kiện CRUD lớp học phần

        private void btnAddMoudleClass_Click(object sender, EventArgs e)
        {
            frmAddModuleClass frmAddModuleClass = new frmAddModuleClass();
            frmAddModuleClass.ShowDialog();
        }

        private void btnEditMoudleClass_Click(object sender, EventArgs e)
        {

            frmViewDetailModuleClass frmViewDetailModuleClass = new frmViewDetailModuleClass(maLop);
            frmViewDetailModuleClass.ShowDialog();
        }
        #endregion

        #region  Xử lý sự kiện CRUD lớp sinh hoạt
        private void btnEditHomeRoomClass_Click(object sender, EventArgs e)
        {
            frmViewDetailHomeroomClass frmViewDetailHomeroomClass = new frmViewDetailHomeroomClass(maLop);
            frmViewDetailHomeroomClass.ShowDialog();
        }
        private void btnAddHomeroomClass_Click(object sender, EventArgs e)
        {
            frmAddHomeroomClass frmAddHomeroomClass = new frmAddHomeroomClass();
            frmAddHomeroomClass.ShowDialog();
        }
        #endregion

        #region Tìm kiếm trên datagridview
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            previousValue = txtSearch.Text;

        }


        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (txtSearch.Text != previousValue)
                {
                    previousValue = txtSearch.Text;
                    return;
                }
                if (autotext.Contains(txtSearch.Text))
                {
                    string[] parts = txtSearch.Text.Split(new string[] { " - " }, StringSplitOptions.None);
                    switch(role)
                    {
                        case 0:
                        case 1:
                            txtSearch.Text = "";
                            frmAddAccount frmAddAccount = new frmAddAccount(role, parts[0]);
                            frmAddAccount.ShowDialog();
                            break;
                        case 2:
                            txtSearch.Text = "";
                            frmViewDetailHomeroomClass frmViewDetailHomeroomClass = new frmViewDetailHomeroomClass(parts[0] + " - " + parts[1]);
                            frmViewDetailHomeroomClass.ShowDialog();
                            break;
                        case 3:
                            txtSearch.Text = "";
                            frmViewDetailModuleClass frmViewDetailModuleClass = new frmViewDetailModuleClass(parts[0]);
                            frmViewDetailModuleClass.ShowDialog();
                            break;
                    }
 


                }
            }
        }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using BLL;

namespace GUI
{
    public partial class frmAdd : Form
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;
        public frmAdd()
        {
            InitializeComponent();
            HideButton();
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
       

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvViewAcc.CellContentClick += new DataGridViewCellEventHandler(dgvViewAcc_CellClick);
            dgvViewAcc.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            dgvViewAcc.CellPainting += new DataGridViewCellPaintingEventHandler(dgvSelectAll_CellPainting);
            BindGridView();
        }
        #region Thêm header checkbox
        private void BindGridView()
        {
            dgvViewAcc.DataSource = GetInformationAcc_BLL.Instance.GetAccountRoleList();
            dgvViewAcc.CurrentCell = null;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Name = "checkBoxColumn";
            dgvViewAcc.Columns.Insert(0, checkBoxColumn);
            TotalCheckBoxes = dgvViewAcc.RowCount;
            TotalCheckedCheckBoxes = 0;

            dgvViewAcc.Columns[1].HeaderText = "Tài khoản";
            dgvViewAcc.Columns[2].HeaderText = "Vai Trò";
            dgvViewAcc.Columns[3].HeaderText = "Họ và tên";
            dgvViewAcc.Columns[4].HeaderText = "CCCD";
            dgvViewAcc.Columns[5].HeaderText = "Email";
            dgvViewAcc.Columns[6].HeaderText = "Mã CTĐT";



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


        #region Sự kiện nhấn vào 1 ô 
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
                    }
                    else
                    {
                        dgvViewAcc.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
                        dgvViewAcc.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromName("ActiveCaption");
                        TotalCheckedCheckBoxes--;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAccStudent frmAddAccStudent = new frmAddAccStudent();
            frmAddAccStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        private void button9_Click(object sender, EventArgs e)
        {

        }


    }
}

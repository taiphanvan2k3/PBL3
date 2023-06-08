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
using static GUI.frmAdmin;

namespace GUI.MyUserControls
{
    public partial class UC_DatagirdviewCheckbox : UserControl
    {
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        CheckBox HeaderCheckBox = null;

        private List<object> list;

        private DataTable dt;

        private SelectionState enumValue;

        private List<string> nameHeaderList;


        public UC_DatagirdviewCheckbox(List<object> list, SelectionState enumValue)
        {
            InitializeComponent();
            this.list = list;
            this.enumValue = enumValue;
            dgvView.DataSource = list;

        }
        public UC_DatagirdviewCheckbox(DataTable dt, SelectionState enumValue)
        {
            InitializeComponent();
            this.dt = dt;
            this.enumValue = enumValue;
            dgvView.DataSource = dt;
        }

        public UC_DatagirdviewCheckbox(List<object> list)
        {
            InitializeComponent();
            this.list = list;
            dgvView.DataSource = list;

        }
        public UC_DatagirdviewCheckbox(DataTable dt, List<string> nameHeaderList)
        {
            InitializeComponent();
            this.dt = dt;
            dgvView.DataSource = dt;
            this.nameHeaderList = nameHeaderList;
        }

        #region Thêm header checkbox
        private void dgvView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if the cell being edited is not in the first column
            if (e.ColumnIndex != 0)
            {
                // Cancel the edit operation
                e.Cancel = true;
            }
        }
        // Thêm 1 cột checkbox vào datagridview ở cột đâu ftiene
        private void BindGridView()
        {
            dgvView.CurrentCell = null;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Name = "checkBoxColumn";
            dgvView.Columns.Insert(0, checkBoxColumn);
            TotalCheckBoxes = dgvView.RowCount;
            TotalCheckedCheckBoxes = 0;
        }

        // Xác định nếu ô hiện tại đang được chỉnh sửa là một ô chứa CheckBox thì nó sẽ thực hiện việc commitEdit để cập nhật dữ liệu.
        private void dgvSelectAll_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvView.CurrentCell is DataGridViewCheckBoxCell)
                dgvView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // khi nhấn vào 1 ô hearder checkbox
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            dgvView.CurrentCell = null;
            HeaderCheckBoxClick((CheckBox)sender);
        }

        // Vẽ ô checkbox header
        private void dgvSelectAll_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }

        // Tạo 1 header checkbox
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            HeaderCheckBox.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            //Add the CheckBox into the DataGridView
            this.dgvView.Controls.Add(HeaderCheckBox);
        }

        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            // Lấy kích thước của ô tiêu đề
            Rectangle oRectangle = this.dgvView.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);
            Point oPoint = new Point();
            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2;
            // Thay đổi vị trí của nó trên header
            HeaderCheckBox.Location = oPoint;
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            //IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in dgvView.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value = HCheckBox.Checked;
            }
            dgvView.RefreshEdit();
            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;
            //IsHeaderCheckBoxClicked = false;
        }

        private void UncheckAllCheckBoxes()
        {
            HeaderCheckBox.Checked = false;
            foreach (DataGridViewRow row in dgvView.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"];
                checkBox.Value = false;
            }
            TotalCheckedCheckBoxes = 0;
        }

        #endregion

        #region Sự kiện nhấn vào 1 ô checkbox
        //Kiểm tra xem checkbox được đánh dấu ở header của datagridview có được chọn hay không.
        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop to verify whether all row CheckBoxes are checked or not.
                bool isChecked = true;
                foreach (DataGridViewRow row in dgvView.Rows)
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

        private void dgvView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkCell = dgvView.Rows[e.RowIndex].Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (checkCell != null)
                {
                    bool isChecked = (bool)checkCell.EditedFormattedValue;
                    dgvView.Rows[e.RowIndex].Selected = isChecked;
                    int selectedRowCount = dgvView.SelectedRows.Count;

                    if (isChecked)
                    {
                        dgvView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
                        dgvView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                        TotalCheckedCheckBoxes++;
                    }
                    else
                    {
                        dgvView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
                        dgvView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromName("ActiveCaption");
                        TotalCheckedCheckBoxes--;
                    }
                }

            }
        }

        #endregion

        private void UC_DatagirdviewCheckbox_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBL3DataSet.NGUOI_DUNG' table. You can move, or remove it, as needed.
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            dgvView.CurrentCellDirtyStateChanged += new EventHandler(dgvSelectAll_CurrentCellDirtyStateChanged);
            dgvView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(dgvView_CellBeginEdit);
            dgvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvView_CellClick);
            dgvView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgvSelectAll_CellPainting);
            dgvView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dgvView_CellValueChanged);
            BindGridView();
            changeNameHeader();
            ChangePropertiesForColumns();
        }

        public void loadData(DataTable dt)
        {
            dgvView.DataSource = dt;
        }

        private void changeNameHeader()
        {
            for (int i = 1; i < nameHeaderList.Count;i++)
            {
                dgvView.Columns[i].HeaderText = nameHeaderList[i];
            }
        }

        private void ChangePropertiesForColumns()
        {
            dgvView.Columns[0].Width = 50;
        }
    }
}

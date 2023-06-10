using BLL;
using DTO;
using GUI.MyCustomControl;
using Microsoft.Office.Interop.Excel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTaoCauHoiNew : Form
    {

        private System.Data.DataTable dtExcel;

        public frmTaoCauHoiNew(int role)
        {
            InitializeComponent();
            panelCreate.Visible = false;
            panelCreateByExcel.Visible = true;
            this.Size = new System.Drawing.Size(600, 800);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            cbMonHoc.Size = new System.Drawing.Size(300, 36);
            cbMonHoc.SelectedIndexChanged += CheckAllConditions_v2;
            cbPhanLoai.SelectedIndexChanged += CheckAllConditions_v2;
        }


        public frmTaoCauHoiNew()
        {
            InitializeComponent();
            panelCreateByExcel.Visible = false;
            tgMultiAnswer.CheckedChanged += CheckAllConditions;
            chbA.CheckedChanged += CheckAllConditions;
            chbB.CheckedChanged += CheckAllConditions;
            chbC.CheckedChanged += CheckAllConditions;
            chbD.CheckedChanged += CheckAllConditions;
            rbA.CheckedChanged += CheckAllConditions;
            rbB.CheckedChanged += CheckAllConditions;
            rbC.CheckedChanged += CheckAllConditions;
            rbD.CheckedChanged += CheckAllConditions;
            tbQuestion._TextChanged += CheckAllConditions;
            tbA._TextChanged += CheckAllConditions;
            tbB._TextChanged += CheckAllConditions;
            tbC._TextChanged += CheckAllConditions;
            tbD._TextChanged += CheckAllConditions;
            cbMonHoc.SelectedIndexChanged += CheckAllConditions;
            cbPhanLoai.SelectedIndexChanged += CheckAllConditions;
        }
        public string MaGV { get; set; }
        private void frmTaoCauHoiNew_Load(object sender, EventArgs e)
        {
            cbMonHoc.Items.Add("Chọn môn học");
            cbMonHoc.Items.AddRange(GiangVien_BLL.Instance.GetMonHocInKhoaForGV(MaGV).ToArray());
            string[] str = { "Chọn phân loại", "Giữa kỳ", "Cuối kỳ", "Test" };
            cbPhanLoai.Items.AddRange(str);
            cbMonHoc.SelectedIndex = 0;
        }
        //Xử lí sự kiện enable button tạo câu hỏi 
        private void CheckAllConditions(object sender, EventArgs e)
        {
            bool MonHocChoosed = !(cbMonHoc.SelectedItem.ToString() == "Chọn môn học");
            if (cbPhanLoai.SelectedIndex == -1)
                cbPhanLoai.SelectedIndex = 0;
            bool PhanLoaiChoosed = !(cbPhanLoai.SelectedItem.ToString() == "Chọn phân loại");
            bool allRbOrChbChecked;
            if (!tgMultiAnswer.Checked)
                allRbOrChbChecked = rbA.Checked || rbB.Checked || rbC.Checked || rbD.Checked;
            else
                allRbOrChbChecked = chbA.Checked || chbB.Checked || chbC.Checked || chbD.Checked;
            bool allTextEntered = (tbQuestion.ForeColor == Color.Black && tbQuestion.Texts != "") &&
                                  (tbA.ForeColor == Color.Black && tbA.Texts != "") &&
                                  (tbB.ForeColor == Color.Black && tbB.Texts != "") &&
                                  (tbC.ForeColor == Color.Black && tbC.Texts != "") &&
                                  (tbD.ForeColor == Color.Black && tbD.Texts != "");

            btnCreateQues.Enabled = MonHocChoosed && PhanLoaiChoosed && allRbOrChbChecked && allTextEntered;
        }
        private void CheckAllConditions_v2(object sender, EventArgs e)
        {
            bool MonHocChoosed = !(cbMonHoc.SelectedItem.ToString() == "Chọn môn học");
            if (cbPhanLoai.SelectedIndex == -1)
                cbPhanLoai.SelectedIndex = 0;
            bool PhanLoaiChoosed = !(cbPhanLoai.SelectedItem.ToString() == "Chọn phân loại");
            btnAdd.Enabled = MonHocChoosed && PhanLoaiChoosed;

        }

        private void tbQuestion_Enter(object sender, EventArgs e)
        {
            if (tbQuestion.Texts == "Nhập câu hỏi")
            {
                tbQuestion.Texts = "";
                tbQuestion.ForeColor = Color.Black;
            }
        }

        private void tbQuestion_Leave(object sender, EventArgs e)
        {
            if (tbQuestion.Texts == "")
            {
                tbQuestion.Texts = "Nhập câu hỏi";
                tbQuestion.ForeColor = Color.DimGray;
            }
        }

        private void tbA_Enter(object sender, EventArgs e)
        {
            if (tbA.Texts == "Nhập đáp án A")
            {
                tbA.Texts = "";
                tbA.ForeColor = Color.Black;
            }
        }

        private void tbA_Leave(object sender, EventArgs e)
        {
            if (tbA.Texts == "")
            {
                tbA.Texts = "Nhập đáp án A";
                tbA.ForeColor = Color.DimGray;
            }
        }

        private void tbB_Enter(object sender, EventArgs e)
        {
            if (tbB.Texts == "Nhập đáp án B")
            {
                tbB.Texts = "";
                tbB.ForeColor = Color.Black;
            }
        }

        private void tbB_Leave(object sender, EventArgs e)
        {
            if (tbB.Texts == "")
            {
                tbB.Texts = "Nhập đáp án B";
                tbB.ForeColor = Color.DimGray;
            }
        }

        private void tbC_Enter(object sender, EventArgs e)
        {
            if (tbC.Texts == "Nhập đáp án C")
            {
                tbC.Texts = "";
                tbC.ForeColor = Color.Black;
            }
        }

        private void tbC_Leave(object sender, EventArgs e)
        {
            if (tbC.Texts == "")
            {
                tbC.Texts = "Nhập đáp án C";
                tbC.ForeColor = Color.DimGray;
            }
        }

        private void tbD_Enter(object sender, EventArgs e)
        {
            if (tbD.Texts == "Nhập đáp án D")
            {
                tbD.Texts = "";
                tbD.ForeColor = Color.Black;
            }
        }

        private void tbD_Leave(object sender, EventArgs e)
        {
            if (tbD.Texts == "")
            {
                tbD.Texts = "Nhập đáp án D";
                tbD.ForeColor = Color.DimGray;
            }
        }

        private void tgMultiAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (tgMultiAnswer.Checked)
            {
                foreach (System.Windows.Forms.CheckBox i in pnlChooseAnswer.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    i.Enabled = true;
                    i.Visible = true;
                }
                foreach (RadioButton i in pnlChooseAnswer.Controls.OfType<RadioButton>())
                {
                    i.Enabled = false;
                    i.Visible = false;
                }
            }
            else
            {
                foreach (System.Windows.Forms.CheckBox i in pnlChooseAnswer.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    i.Enabled = false;
                    i.Visible = false;
                }
                foreach (RadioButton i in pnlChooseAnswer.Controls.OfType<RadioButton>())
                {
                    i.Enabled = true;
                    i.Visible = true;
                }
            }
        }
        private void ReloadForm()
        {
            tbQuestion.Texts = "";
            tbA.Texts = "";
            tbB.Texts = "";
            tbC.Texts = "";
            tbD.Texts = "";
            foreach (Control control in pnlChooseAnswer.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)(control)).Checked = false;
                }
                else if (control is System.Windows.Forms.CheckBox)
                    ((System.Windows.Forms.CheckBox)(control)).Checked = false;
            }
            tgMultiAnswer.Checked = false;
            cbMonHoc.SelectedIndex = 0;
            cbPhanLoai.SelectedIndex = 0;
        }

        private void btnCreateQues_Click(object sender, EventArgs e)
        {
            string DapAnDung = "";
            string PhanLoai = "";
            if (cbPhanLoai.SelectedItem.ToString() == "Giữa kỳ")
                PhanLoai = "GK";
            else if (cbPhanLoai.SelectedItem.ToString() == "Cuối kỳ")
                PhanLoai = "CK";
            else if (cbPhanLoai.SelectedItem.ToString() == "Test")
                PhanLoai = "Test";
            foreach (Control control in pnlChooseAnswer.Controls)
            {
                if (tgMultiAnswer.Checked)
                {
                    if (control is System.Windows.Forms.CheckBox)
                    {
                        if (((System.Windows.Forms.CheckBox)(control)).Checked)
                        {
                            DapAnDung += control.Name.ToString()[control.Name.ToString().Length - 1];
                        }
                    }
                }
                else
                {
                    if (control is RadioButton)
                    {
                        if (((RadioButton)(control)).Checked)
                        {
                            DapAnDung += control.Name.ToString()[control.Name.ToString().Length - 1];
                        }
                    }
                }
            }
            DapAnDung = DapAnDung.ToLower();
            char[] charArray = DapAnDung.ToCharArray();
            Array.Sort(charArray);
            DapAnDung = new string(charArray);
            GiangVien_BLL.Instance.CreateQuestion(tbQuestion.Texts, tbA.Texts, tbB.Texts, tbC.Texts, tbD.Texts, DapAnDung, ((CBBItem)cbMonHoc.SelectedItem).Id, PhanLoai);
            CustomMessageBox.Show("Tạo câu hỏi thành công!");
            ReloadForm();
        }



        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm", Multiselect = false }) //open dialog to choose file
            {
                if (ofd.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
                {
                    try
                    {
                        pnlProgressBar.Visible = true;
                        backgroundWorkerLoadFileLocal.RunWorkerAsync(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void backgroundWorkerLoadFileLocal_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string filePath = (string)e.Argument;
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb;
                Worksheet ws;
                wb = excel.Workbooks.Open(filePath);
                ws = wb.Worksheets[1];
                Range usedRange = ws.UsedRange;
                object[,] data = usedRange.Value;
                System.Data.DataTable dt = new System.Data.DataTable();
                for (int i = 1; i <= usedRange.Columns.Count; i++)
                {
                    string columnName = Convert.ToString(data[1, i]);
                    if (!string.IsNullOrEmpty(columnName))
                    {
                        dt.Columns.Add(columnName);
                    }
                }
                for (int i = 2; i <= usedRange.Rows.Count; i++)
                {
                    DataRow tempRow = dt.NewRow();
                    for (int j = 1; j <= usedRange.Columns.Count; j++)
                    {
                        tempRow[j - 1] = data[i, j];
                    }
                    dt.Rows.Add(tempRow);
                    // Report progress
                    int progressPercentage = (i * 100) / usedRange.Rows.Count;
                    backgroundWorkerLoadFileLocal.ReportProgress(progressPercentage);
                }
                e.Result = dt;
                wb.Close();
                excel.Quit();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorkerLoadFileLocal_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void backgroundWorkerLoadFileLocal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgressBar.Visible = false;

            if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else if (e.Result != null)
            {
                dtExcel = (System.Data.DataTable)e.Result;
                dataGridView1.DataSource = dtExcel;
                MessageBox.Show("Đọc file thành công");
            }
            else
            {
                MessageBox.Show("Đọc file thất bại");
                dataGridView1.DataSource = null;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtExcel == null)
            {
                MessageBox.Show("Vui lòng tải tệp lên");
            }
            else
            {
                pnlProgressBar.Visible = true;
                progressBar1.Value = progressBar1.Minimum;
                backgroundWorkerLoadData.RunWorkerAsync();
            }

        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlProgressBar.Visible = false;

            if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else 
            {
                MessageBox.Show("Đọc dữ liệu thành công");
            }

        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            string PhanLoai = "";
            if (cbPhanLoai.SelectedItem.ToString() == "Giữa kỳ")
                PhanLoai = "GK";
            else if (cbPhanLoai.SelectedItem.ToString() == "Cuối kỳ")
                PhanLoai = "CK";
            else if (cbPhanLoai.SelectedItem.ToString() == "Test")
                PhanLoai = "Test";
            int i = 1;
            foreach (DataRow row in dtExcel.Rows)
            {
                GiangVien_BLL.Instance.CreateQuestion(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), ((CBBItem)cbMonHoc.SelectedItem).Id, PhanLoai);
                int progressPercentage = (i * 100) / dtExcel.Rows.Count;
                backgroundWorkerLoadData.ReportProgress(progressPercentage);
                i++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void backgroundWorkerLoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage}%";
        }
    }
}

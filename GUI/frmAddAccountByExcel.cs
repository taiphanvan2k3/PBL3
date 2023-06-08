using BLL;
using DTO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Windows.Controls;
using System.Security.Cryptography;
using GUI.MyCustomControl;
using static GUI.frmAdmin;

namespace Testexcel
{
    public partial class frmAddAccountByExcel : Form
    {

        private System.Data.DataTable dtExcel;
        private int role;
        private SelectionState enumValue;
        int checkBtn;

        // Khai báo delegate và event
        public delegate void DataAddedSuccessHandler();
        public event DataAddedSuccessHandler DataAddedSuccessEvent;

        public frmAddAccountByExcel(int role)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(this);
            this.role = role;
        }

        public frmAddAccountByExcel(SelectionState enumValue)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(this);
            this.enumValue = enumValue;
        }

        // Lấy chuỗi id của url
        public static string GetSheetIdFromUrl(string url)
        {
            string pattern = @"\/spreadsheets\/d\/([a-zA-Z0-9-_]+";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(url);
            return match.Success ? match.Groups[1].Value : null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
            DataAddedSuccessEvent?.Invoke();

        }

        #region Thêm button vào trong textbox
        protected override void OnLoad(EventArgs e)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Size = new Size(25, txtPath.ClientSize.Height + 2);
            btn.Location = new System.Drawing.Point(txtPath.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.Click += btnUpLoadFileFromDrive_Click;

            txtPath.Controls.Add(btn);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(txtPath.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
            base.OnLoad(e);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnUpLoadFileFromDrive_Click(object sender, EventArgs e)
        {
            checkBtn = 1;
            if (txtPath.Text.ToString() == "")
            {
                CustomMessageBox.Show("Hãy nhập liên kết tới file sheet cần đọc");
            }
            else
            {
                    try
                    {
                    pnlProgressBar.Visible = true;
                    backgroundWorkerLoadFileDrive.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        #endregion

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            checkBtn = 2;
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

        // Xử lý thêm dữ liệu vào 
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (dtExcel == null)
            {
                MessageBox.Show("Vui lòng tải tệp lên");
            }
            else
            {

                Random random = new Random();

                int countSV;
                int countGV;
                DateTime dateTime = DateTime.Now;


                int countEror = 0;

                foreach (DataRow row in dtExcel.Rows)
                {
                    try
                    {
                        string cccd = row[1].ToString();
                        Regex regex = new Regex("^[0-9]{12}$"); // biểu thức chính quy kiểm tra chuỗi có độ dài bằng 12 và chỉ chứa số
                        if (!regex.IsMatch(cccd))
                        {
                            break;
                        }
                        else
                        {
                            string date = row[4].ToString();

                            string maTk = "";
                            string sex = row[5].ToString();
                            THONG_TIN_DANG_NHAP_DTO ttdn = new THONG_TIN_DANG_NHAP_DTO();

                            ttdn.MkUngDung = cccd;
                            ttdn.MaXacThucDeLayLaiMK = null;
                            ttdn.ThoiGianTao = dateTime;


                            NguoiDung_DTO nd = new NguoiDung_DTO();

                            nd.Ho = row[2].ToString();
                            nd.Ten = row[3].ToString();
                            nd.MaCCCD = cccd;
                            nd.AnhCaNhan = null;
                            if (checkBtn == 1)
                            {
                                nd.NgaySinh = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                            }
                            else if (checkBtn == 2)
                            {
                                nd.NgaySinh = Convert.ToDateTime(date);
                            }
                            if (sex == "0")
                            {
                                nd.GioiTinh = false;
                            }
                            else if (sex == "1")
                            {
                                nd.GioiTinh = true;
                            }
                            nd.DanToc = null;
                            nd.QuocTich = null;
                            nd.NoiSinh = null;
                            nd.DiaChi = null;
                            nd.Sdt = null;
                            nd.EmailCaNhan = null;
                            nd.MkEmailTruongCap = cccd;


                            if (role == 0)
                            {
                                countSV = GetInformationAcc_BLL.Instance.getTheNumberOfStudentByFaculty(row[0].ToString().Substring(0, 3), row[0].ToString().Substring(3));
                                countSV++;
                                maTk = row[0].ToString() + countSV.ToString("D4");
                                SinhVien_DTO svDT = new SinhVien_DTO()
                                {
                                    MaNguoiDung = maTk,
                                    MaCTDT = row[6].ToString(),
                                    MaLopSH = null
                                };
                                ttdn.TaiKhoan = maTk;
                                ttdn.VaiTro = "Sinh Viên";
                                nd.MaNguoiDung = maTk;
                                nd.EmailTruongCap = maTk + "SV@emailling.xyz";
                                if (GetInformationAcc_BLL.Instance.InsertData(ttdn, nd, svDT) == true)
                                {
                                    countEror++;
                                }
                                else
                                    break;
                            }
                            else
                            {
                                countGV = GetInformationAcc_BLL.Instance.getTheNumberOfTeacherByFaculty(row[6].ToString());
                                countGV++;
                                maTk = row[0].ToString() + countGV.ToString("D4"); ;
                                GiangVien_DTO gvDT = new GiangVien_DTO()
                                {
                                    MaNguoiDung = maTk,
                                    TrinhDo = row[7].ToString(),
                                    Luong = null,
                                    MaKhoa = row[6].ToString(),
                                };
                                ttdn.TaiKhoan = maTk;
                                ttdn.VaiTro = "Giáo Viên";
                                nd.MaNguoiDung = maTk;
                                nd.EmailTruongCap = maTk + "GV@emailling.xyz";
                                if (GetInformationAcc_BLL.Instance.InsertData(ttdn, nd, gvDT) == true)
                                {
                                    countEror++;
                                }
                                else
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }

                if (countEror == dtExcel.Rows.Count)
                {
                    MessageBox.Show("Đã thêm được toàn bộ dữ liệu");
                }
                else
                {
                    MessageBox.Show("Đã thêm được " + countEror + " dòng dữ liệu!");
                    MessageBox.Show("Có lỗi tại dòng " + ++countEror + " trong file Excel.\nVui lòng kiểm tra lại");
                }
            }

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
            catch(Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
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

        private void backgroundWorkerLoadFileDrive_DoWork(object sender, DoWorkEventArgs e)
        {
            checkBtn = 1;

            UserCredential credential;
            string[] scopes = { SheetsService.Scope.SpreadsheetsReadonly };
            string filePath = Path.Combine("..","..", "..", "BLL", "credentials.json");
            using (var stream =
               new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Sheets API",
            });


            // Define request parameters.
            string spreadsheetId = GetSheetIdFromUrl(txtPath.Text.ToString());
            string range = "Sheet1!A1:Z";

            try
            {
                // Get values from sheet.
                var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = request.Execute();
                IList<IList<Object>> values = response.Values;

                // Load data into DataTable.
                System.Data.DataTable dataTable = new System.Data.DataTable();
                if (values != null && values.Count > 0)
                {
                    // Add columns to DataTable.
                    foreach (var header in values[0])
                    {
                        dataTable.Columns.Add(header.ToString());
                    }

                    // Add rows to DataTable.
                    foreach (var row in values.Skip(1))
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < row.Count; i++)
                        {
                            dataRow[i] = row[i];
                            // Report progress
                            int progressPercentage = (i * 100) / row.Count;
                            backgroundWorkerLoadFileDrive.ReportProgress(progressPercentage);
                        }
                        dataTable.Rows.Add(dataRow);

                    }
                }
                e.Result = dataTable;
            }
            catch (Exception ex)
            {
                e.Result = null;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

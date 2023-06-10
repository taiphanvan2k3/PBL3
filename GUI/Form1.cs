using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class Form1 : Form
    {

        private System.Data.DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(?<=\. )\s*(.*)");
            dt = new System.Data.DataTable();
            for (int i = 1; i <= 5; i++)
            {
                dt.Columns.Add("Column " + i);
            }
            for (int i = 1; i <= 50; i++)
            {
                dt.Rows.Add(dt.NewRow());
            }

            // Đọc dữ liệu từ file văn bản và gán vào DataTable
            int row = 0;
            int lenRow = 0;

            StreamReader sr = new StreamReader("C:\\Users\\TEMP.THANHNGAN13.005\\Documents\\dethi.txt");
            while (!sr.EndOfStream && row < dt.Rows.Count)
            {
                string line = sr.ReadLine();
                if (lenRow == 0)
                    line = regex.Match(line).Value;
                dt.Rows[row][lenRow] = line;
                lenRow++;
                if (lenRow == 5)
                {
                    row++;
                    lenRow = 0;
                }
            }
            sr.Close();

            // In ra DataTable
            dataGridView1.DataSource = dt;
        }


        // Chuyển datatable to excel
        public void ExportToExcel(System.Data.DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm", Multiselect = false }) //open dialog to choose file
            {
                if (ofd.ShowDialog() == DialogResult.OK) //if there is a file chosen by the user
                {
                    try
                    {
                        string fileName = ofd.FileName;
                        ExportToExcel(dt, fileName);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                }
            }
        }
    }
}


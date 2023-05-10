﻿using BLL;
using DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class testData : Form
    {
        private AutoCompleteStringCollection autotext;
        private string previousValue;
        private BindingSource bindingSource = new BindingSource();

        public testData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = GetInformationAcc_BLL.Instance.getTheNumberOfStudentByFaculty(textBox1.Text.ToString().Substring(0, 3), textBox1.Text.ToString().Substring(3));
            MessageBox.Show(result.ToString());
        }

        private void testData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBL3DataSet.GIANG_VIEN' table. You can move, or remove it, as needed.

            //dgvViewAcc.DataSource = GetInformationAcc_BLL.Instance.GetAccountStudentList(); 
            //autotext = new AutoCompleteStringCollection();
            //List<object> dt = new List<object>();
            //dt = GetInformationAcc_BLL.Instance.GetAccountStudentList().Cast<object>().ToList();
            //autotext.AddRange(dt.Select(x => ((InformationStudent_DTO)x).TaiKhoan + " - " + ((InformationStudent_DTO)x).Ten).ToArray());
            //guna2TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //guna2TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //guna2TextBox1.AutoCompleteCustomSource = autotext;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            previousValue = guna2TextBox1.Text;
        }


        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (guna2TextBox1.Text != previousValue)
                {
                    previousValue = guna2TextBox1.Text;
                    return;
                }
                if (autotext.Contains(guna2TextBox1.Text))
                {
                    string[] parts = guna2TextBox1.Text.Split(new string[] { " - " }, StringSplitOptions.None);
                    MessageBox.Show("Bạn đã chọn gợi ý: " + parts[0]);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(textBox1.Text);


            }
        }

        private DataTable readTXT()
        {
            DataTable dt = new DataTable();
            for (int i = 1; i <= 5; i++)
            {
                dt.Columns.Add("Column " + i);
            }
            for (int i = 1; i <= 50; i++)
            {
                dt.Rows.Add(dt.NewRow());
            }
            MessageBox.Show(dt.Rows.Count.ToString());

            // Đọc dữ liệu từ file văn bản và gán vào DataTable
            int row = 0;
            int collum = 0;
            int d = 0;
            StreamReader sr = new StreamReader("C:\\Users\\TEMP.THANHNGAN13.005\\Documents\\dethi.txt");
            while (!sr.EndOfStream && row < dt.Rows.Count)
            {
                string[] values = sr.ReadLine().Split('\t');
                dt.Rows[row][collum] = values[0];
                collum++;
                d++;
                if (d % 5 == 0)
                {
                    row++;
                    collum = 0;
                }
            }
            sr.Close();
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvViewAcc.DataSource = readTXT();  
        }
    }
}
